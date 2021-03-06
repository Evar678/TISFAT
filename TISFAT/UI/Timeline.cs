﻿using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TISFAT.Util;

namespace TISFAT
{
	public partial class Timeline
	{
		#region Properties
		public GLControl GLContext;
		public bool LastHovered = false;
		public bool IsMouseDown = false;
		public bool IsDragging = false;

		public uint KeyframeDragStartTime;
		public uint FramesetDragStartTime;

		private float FrameNum;
		private DateTime? PlayStart;

		public Point MouseDragStart;
		public bool IsDraggingKeyframe = false;
		public bool IsDraggingFrameset = false;

		public float SplitterDistance = 80;
		public bool HoveringSplitter = false;
		public bool IsDraggingSplitter = false;

		public int HoveredLayerIndex = -1;
		public bool HoveredLayerOverVis = false;

		public Layer SelectedLayer
		{
			get { return selectedItems.GetSelected(SelectionType.Layer) as Layer; }
		}
		public Frameset SelectedFrameset
		{
			get { return selectedItems.GetSelected(SelectionType.Frameset) as Frameset; }
		}
		public Keyframe SelectedKeyframe
		{
			get { return selectedItems.GetSelected(SelectionType.Keyframe) as Keyframe; }
		}

		public int selectedTime
		{
			get { return selectedItems.Time; }
		}

		public TimelineSelection selectedItems = new TimelineSelection();

		public int VisibilityBitmapOn;
		public int VisibilityBitmapOn_hover;
		public int VisibilityBitmapOff;
		public int VisibilityBitmapOff_hover;
		#endregion

		#region CTOR | OpenGL core functions
		public Timeline(GLControl context)
		{
			GLContext = context;

			FrameNum = 0.0f;
			PlayStart = null;
		}

		public void GLContext_Init()
		{
			GLContext.MakeCurrent();

			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
			GL.Viewport(0, 0, GLContext.Width, GLContext.Height);
			GL.Ortho(0, GLContext.Width, GLContext.Height, 0, -1, 1);
			GL.Disable(EnableCap.DepthTest);

			if (VisibilityBitmapOn == 0)
			{
				// Create visibility button bitmaps
				VisibilityBitmapOn = Drawing.GenerateTexID(Properties.Resources.eye);
				VisibilityBitmapOn_hover = Drawing.GenerateTexID(Properties.Resources.eye_hover);
				VisibilityBitmapOff = Drawing.GenerateTexID(Properties.Resources.eye_off);
				VisibilityBitmapOff_hover = Drawing.GenerateTexID(Properties.Resources.eye_off_hover);
			}
		}

		public void Resize()
		{
			// Reinit OpenGL
			GLContext_Init();

			// Resize scrollbars
			int LastTime = GetLastTime();

			int HContentLength = (LastTime + 101) * 9;
			int VContentLength = (Program.ActiveProject.Layers.Count) * 16 + 16;

			int TotWidth = GLContext.Width - (int)SplitterDistance;
			int TotHeight = GLContext.Height;

			if (Program.Form_Main.Form_Timeline.VScrollVisible)
				TotWidth -= 17;

			if (Program.Form_Main.Form_Timeline.HScrollVisible)
				TotHeight -= 18;

			Program.Form_Main.Form_Timeline.CalcScrollBars(HContentLength, VContentLength, TotWidth, TotHeight);
		}
		#endregion

		public int GetLastTime()
		{
			List<Layer> Layers = Program.ActiveProject.Layers;
			int LastTime = 0;
			foreach (Layer layer in Layers)
				if(layer.Type == LayerTypeEnum.Entity)
					if(layer.Data.GetType() != typeof(Camera))
						LastTime = (int)Math.Max(layer.Framesets[layer.Framesets.Count - 1].EndTime, LastTime);

			return LastTime;
		}

		#region Seeking / Playback Functions
		public void SeekStart()
		{
			FrameNum = 0.0f;
			ClearSelection();
			GLContext.Invalidate();
		}

		public void SeekFirstFrame()
		{
			Project project = Program.ActiveProject;

			foreach (Layer layer in project.Layers)
				FrameNum = Math.Min(FrameNum, layer.Framesets[0].StartTime);

			ClearSelection();
			GLContext.Invalidate();
		}

		public bool CheckKeyframe(int time)
		{
			Keyframe target = null;

			foreach (Frameset f in SelectedLayer.Framesets)
			{
				foreach (Keyframe frame in f.Keyframes)
				{
					if (frame.Time == time)
					{
						target = frame;

						selectedItems.Select(frame);
						break;
					}
				}

				if (target != null)
					break;
			}

			return target == null;
		}

		public Tuple<int, Frameset, Keyframe> FindAtTime(int time)
		{ 
			Frameset frameset = null;
			Keyframe frame = null;

			foreach(Frameset f in SelectedLayer.Framesets)
			{
				if(f.StartTime <= time && f.EndTime >= time)
				{
					frameset = f;
					break;
				}
			}

			if(frameset == null)
				return new Tuple<int, Frameset, Keyframe>(0, null, null); // null frame

			foreach(Keyframe k in frameset.Keyframes)
			{
				if (k.Time == time)
				{
					frame = k;
					break;
				}
			}

			if (frame == null)
				return new Tuple<int, Frameset, Keyframe>(1, frameset, null); // blank frame

			return new Tuple<int, Frameset, Keyframe>(2, frameset, frame); // keyframe
		}

		public void SeekPrevFrame()
		{
			if (selectedItems.Contains(SelectionType.NullFrame) ||
				selectedItems.Contains(SelectionType.BlankFrame) ||
				selectedItems.Contains(SelectionType.Keyframe))
			{
				int time = selectedItems.Time;

				time--;

				if (time < 0)
					return;

				Tuple<int, Frameset, Keyframe> result = FindAtTime(time);

				switch (result.Item1)
				{
					case 0:
						selectedItems.Select(SelectionType.NullFrame, time);
						break;
					case 1:
						selectedItems.Select(SelectionType.BlankFrame, time);
						selectedItems.Select(result.Item2);
						break;
					case 2:
						selectedItems.Select(result.Item2, result.Item3);
						break;
				}

			}

			if(FrameNum > 0)
				FrameNum--;
			GLContext.Invalidate();
		}

		public void SeekNextFrame()
		{
			if (selectedItems.Contains(SelectionType.NullFrame) ||
				selectedItems.Contains(SelectionType.BlankFrame) ||
				selectedItems.Contains(SelectionType.Keyframe))
			{
				int time = selectedItems.Time;

				time++;

				if (time < 0)
					return;

				Tuple<int, Frameset, Keyframe> result = FindAtTime(time);

				switch (result.Item1)
				{
					case 0:
						selectedItems.Select(SelectionType.NullFrame, time);
						break;
					case 1:
						selectedItems.Select(SelectionType.BlankFrame, time);
						selectedItems.Select(result.Item2);
						break;
					case 2:
						selectedItems.Select(result.Item2, result.Item3);
						break;
				}
			}

			FrameNum++;
			GLContext.Invalidate();
		}

		public void SeekLastFrame()
		{
			Project project = Program.ActiveProject;

			foreach (Layer layer in project.Layers)
				FrameNum = Math.Max(FrameNum, layer.Framesets[layer.Framesets.Count - 1].EndTime);

			ClearSelection();
			GLContext.Invalidate();
		}

		public void NextKeyframe()
		{
			Keyframe frame = null;

			if (selectedItems.Contains(SelectionType.Keyframe))
			{
				int KeyframeIndex = SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) + 1;

				if (KeyframeIndex + 1 > SelectedFrameset.Keyframes.Count)
					return;

				frame = SelectedFrameset.Keyframes[KeyframeIndex];
			}
			else if (selectedItems.Contains(SelectionType.BlankFrame))
			{
				int time = selectedItems.Time;

				foreach(Keyframe k in SelectedFrameset.Keyframes)
				{
					if(k.Time > time)
					{
						frame = k;
						break;
					}
				}
			}

			if (frame != null)
			{
				selectedItems.Select(frame);
				GLContext.Invalidate();
			}
		}

		public void PrevKeyframe()
		{
			Keyframe frame = null;

			if (selectedItems.Contains(SelectionType.Keyframe))
			{
				int KeyframeIndex = SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) - 1;

				if (KeyframeIndex < 0)
					return;

				frame = SelectedFrameset.Keyframes[KeyframeIndex];
			}
			else if (selectedItems.Contains(SelectionType.BlankFrame))
			{
				int time = selectedItems.Time;

				foreach (Keyframe k in SelectedFrameset.Keyframes)
				{
					if (k.Time < time)
					{
						frame = k;
						break;
					}
				}
			}

			if (frame != null)
			{
				selectedItems.Select(frame);
				GLContext.Invalidate();
			}			
		}

		public void TogglePause()
		{
			ClearSelection();

			if (PlayStart != null)
			{
				FrameNum = GetCurrentFrame();
				PlayStart = null;
			}
			else
			{
				PlayStart = DateTime.Now;
				GLContext.Invalidate();
			}
		}

		public float GetCurrentFrame()
		{
			if (selectedTime != -1)
				return selectedTime;

			float frame;

			if (PlayStart != null)
			{
				frame = ((float)(DateTime.Now - (DateTime)PlayStart).TotalSeconds);
				float x = 1.0f / Program.ActiveProject.FPS;
				frame = (float)Math.Floor(frame / x) * x;
				frame *= Program.ActiveProject.AnimSpeed;
            }
			else
				frame = 0.0f;

			return FrameNum + frame;
		}

		public int GetFrameType()
		{
			if (selectedItems.Contains(SelectionType.Keyframe))
				return 2;

			if (selectedItems.Contains(SelectionType.BlankFrame))
				return 1;

			if (selectedItems.Contains(SelectionType.NullFrame))
				return 0;

			return -1;
		}

		public bool IsPlaying()
		{
			return PlayStart != null;
		}
		#endregion

		public void ClearSelection()
		{
			selectedItems.Clear();
		}

		public void SelectFrame(Point location)
		{
			// Select keyframes
			Project project = Program.ActiveProject;

			int frameIndex = (int)Math.Floor((location.X - SplitterDistance) / 9.0);
			int layerIndex = (int)Math.Floor((location.Y - 16) / 16.0);
			FrameNum = (float)Math.Max(0, Math.Floor((location.X - SplitterDistance - 1) / 9.0f));

			if (layerIndex < 0)
			{
				if (PlayStart != null)
					PlayStart = DateTime.Now;

				GLContext.Invalidate();

				return;
			}

			if (layerIndex >= project.Layers.Count)
				return;

			Layer layer = project.Layers[layerIndex];

			ClearSelection();

			if(layer.Type == LayerTypeEnum.Entity)
			{
				foreach (Frameset frameset in layer.Framesets)
				{
					foreach (Keyframe keyframe in frameset.Keyframes)
					{
						if (keyframe.Time == frameIndex)
						{
							selectedItems.Select(layer, frameset, keyframe);

							GLContext.Invalidate();
							return;
						}
					}

					if (frameIndex > frameset.StartTime && frameIndex < frameset.EndTime)
					{
						selectedItems.Select(SelectionType.BlankFrame, frameIndex);
						selectedItems.Select(layer, frameset);

						GLContext.Invalidate();
						return;
					}

				}
			}

			selectedItems.Select(SelectionType.NullFrame, frameIndex);
			selectedItems.Select(layer);

			GLContext.Invalidate();
		}

		public void GLContext_Paint(object sender, PaintEventArgs e)
		{
			List<Layer> Layers = Program.ActiveProject.Layers;

			float lastFrame = 0;
			int layerHeight = 0;

			foreach (Layer layer in Layers)
			{
				if (layer.Type == LayerTypeEnum.Entity)
					lastFrame = Math.Max(lastFrame, layer.Framesets[layer.Framesets.Count - 1].EndTime);

				layerHeight += layer.ThisShouldBeInTimeline(layer);
			}

			int frameCount = (int)Math.Ceiling(lastFrame + 101);
			int frameWidth = frameCount * 9;

			int dist = GLContext.Height - 17;
			int TotalLayerHeight = Math.Min(Layers.Count * 16 + 16, dist);

			GLContext.MakeCurrent();

			GL.ClearColor(Color.FromArgb(220, 220, 220));

			GL.Clear(ClearBufferMask.ColorBufferBit);

			int scrollX = Program.Form_Main.Form_Timeline.HScrollVal;
			int scrollY = Program.Form_Main.Form_Timeline.VScrollVal > 0 ? Program.Form_Main.Form_Timeline.VScrollVal - 1 : 0;

			GL.Translate(-scrollX, -scrollY, 0);

			DrawBackground(frameCount, layerHeight);

			DrawKeyframes(Layers);

			DrawMisc(Layers, layerHeight, frameWidth, frameCount);

			GL.Translate(0, scrollY, 0);
			DrawTimelineNumbers(frameCount, layerHeight);
			DrawPlayhead();
			GL.Translate(0, -scrollY, 0);

			DrawTimelineOutlines(frameCount, layerHeight);

			// Stop translating the drawing by x
			GL.Translate(scrollX, 0, 0);

			DrawLabels(Layers);

			// Stop translating the drawing by y
			GL.Translate(0, scrollY, 0);

			DrawTimelineLayer();

			// Draw rect below layers to hide bottom of playhead when
			// scrolling past the displayed layers.
			//Drawing.Rectangle(new PointF(0, Layers.Count * 16 + 17), new SizeF(81, GLContext.Height - (Layers.Count * 16 + 16)), Color.FromArgb(220, 220, 220));

			GLContext.SwapBuffers();

			Program.Form_Main.Form_Canvas.GLContext_Paint(sender, e);

			if (IsPlaying())
			{
				Application.DoEvents();
				GLContext.Invalidate();
			}
		}

		#region Mouse Events
		public void MouseDown(Point location, MouseButtons button)
		{
			Point locationActual = location;
			location = new Point(location.X + Program.Form_Main.Form_Timeline.HScrollVal, location.Y + Program.Form_Main.Form_Timeline.VScrollVal);

			IsMouseDown = true;
			MouseDragStart = location;

			if (IsPlaying())
				return;

			if (location.X - Program.Form_Main.Form_Timeline.HScrollVal > SplitterDistance && !HoveringSplitter)
			{
				ClearSelection();

				if (PlayStart != null)
					PlayStart = DateTime.Now;

				SelectFrame(location);

				if (button == MouseButtons.Right)
					return;

				if (SelectedKeyframe != null)
				{
					KeyframeDragStartTime = SelectedKeyframe.Time;
					IsDraggingKeyframe = true;
				}
				else if (selectedItems.Contains(SelectionType.BlankFrame) && selectedTime != -1)
				{
					FramesetDragStartTime = SelectedFrameset.Keyframes[0].Time;
					IsDraggingFrameset = true;
				}
			}
			else if (button == MouseButtons.Left)
			{
				if (HoveringSplitter)
				{
					IsDraggingSplitter = true;
					return;
				}

				if (HoveredLayerIndex >= 0 && HoveredLayerIndex < Program.ActiveProject.Layers.Count)
					if (HoveredLayerOverVis)
					{
						Program.ActiveProject.Layers[HoveredLayerIndex].Visible =
							!Program.ActiveProject.Layers[HoveredLayerIndex].Visible;

						GLContext.Invalidate();
					}
			}
		}

		public void MouseMoved(Point location)
		{
			Point locationActual = location;
			location = new Point(location.X + Program.Form_Main.Form_Timeline.HScrollVal, location.Y + Program.Form_Main.Form_Timeline.VScrollVal);

			if (HoveredLayerIndex > -1)
			{
				HoveredLayerIndex = -1;
				Program.Form_Main.Cursor = Cursors.Default;
				GLContext.Invalidate();
			}

			if (MathUtil.PointInRect(locationActual, new RectangleF(new PointF(SplitterDistance - 2, 16), new SizeF(4, Program.ActiveProject.Layers.Count * 16))))
			{
				Program.Form_Timeline.Cursor = Cursors.VSplit;
				HoveringSplitter = true;
			}
			else
			{
				Program.Form_Timeline.Cursor = Cursors.Default;
				HoveringSplitter = false;
			}

			if (IsDraggingSplitter)
			{
				SplitterDistance = Math.Max(locationActual.X, 80);
				Resize();
				GLContext.Invalidate();
				return;
			}

			if (location.X - Program.Form_Main.Form_Timeline.HScrollVal > SplitterDistance)
			{
				if (IsMouseDown)
					IsDragging = true;

				if (IsDraggingKeyframe) // Keyframe stuff
				{
					uint TargetTime = (uint)Math.Max(0, Math.Floor((location.X - SplitterDistance - 1) / 9.0f));

					for (int i = SelectedLayer.Framesets.IndexOf(SelectedFrameset) - 1; i < SelectedLayer.Framesets.IndexOf(SelectedFrameset) + 2; i++)
					{
						if (i == -1 || i > SelectedLayer.Framesets.Count - 1)
							continue;
						if (SelectedLayer.Framesets[i] == SelectedFrameset)
							continue;

						if (i < SelectedLayer.Framesets.IndexOf(SelectedFrameset))
						{
							if (TargetTime <= SelectedLayer.Framesets[i].EndTime)
								return;
						}
						else
							if (TargetTime >= SelectedLayer.Framesets[i].StartTime)
								return;
					}

					if (TargetTime >= SelectedFrameset.StartTime)
					{
						foreach (Keyframe frame in SelectedFrameset.Keyframes)
						{
							if (frame != SelectedKeyframe)
								if (frame.Time == TargetTime)
									return;
						}
					}
					else if (SelectedKeyframe.Time != SelectedFrameset.StartTime && SelectedKeyframe.Time != SelectedFrameset.EndTime)
						return;

					SelectedKeyframe.Time = TargetTime;
					SelectedFrameset.Keyframes = SelectedFrameset.Keyframes.OrderBy(o => o.Time).ToList();

					// Recalc Scrollbars
					Resize();
					GLContext.Invalidate();
				}
				else if (IsDraggingFrameset) // Frameset stuff
				{
					int StartTime = (int)Math.Max(0, Math.Floor((MouseDragStart.X - SplitterDistance - 1) / 9.0f));
					int TargetTime = (int)Math.Max(0, Math.Floor((location.X - SplitterDistance - 1) / 9.0f));
					int NewTime = TargetTime - StartTime;

					float NewStartTime = SelectedFrameset.StartTime + NewTime;
					float NewEndTime = SelectedFrameset.EndTime + NewTime;

					//uhhh here you check if anything is overlapping but i dont quite remember gimme a minute
					// btw the amount of frames a frameset takes up can be figured out with frameset.duration
					// which is just frameset.starttime - frameset.endtime

					if (NewStartTime < 0)
						return;


					foreach (Frameset x in SelectedLayer.Framesets)
					{
						if (x == SelectedFrameset)
							continue;

						if (NewStartTime > x.EndTime)
							continue;
						else if (NewEndTime < x.StartTime)
							continue;

						return;
					}

					foreach (Keyframe frame in SelectedFrameset.Keyframes)
						frame.Time = (uint)(frame.Time + NewTime);

					SelectedLayer.Framesets = SelectedLayer.Framesets.OrderBy(o => o.EndTime).ToList();

					selectedItems.Select(SelectionType.BlankFrame, (int)TargetTime);

					MouseDragStart = location;

					// Recalc Scrollbars
					Resize();
					GLContext.Invalidate();
				}
				else if (IsDragging)
				{
					if (PlayStart != null)
						PlayStart = DateTime.Now;

					FrameNum = (float)Math.Max(0, Math.Floor((location.X - SplitterDistance - 1) / 9.0f));
					GLContext.Invalidate();
				}
			}
			else // Do stuff for whether you're hovering over a visibility button
			{
				int y = locationActual.Y + Program.Form_Main.Form_Timeline.VScrollVal;

				HoveredLayerIndex = (int)Math.Floor((y - 16) / 16.0);
				GLContext.Invalidate();

				if (HoveredLayerIndex > Program.ActiveProject.Layers.Count - 1 || HoveredLayerIndex == -1)
					return;

				if (HoveredLayerIndex == 0)
				{
					HoveredLayerIndex = -1;
					return;
				}

				RectangleF VisButton = new RectangleF(new PointF(SplitterDistance - 15, 16 * (HoveredLayerIndex + 1) + 2), new SizeF(14, 14));
				if (MathUtil.PointInRect(new PointF(locationActual.X, y), VisButton))
				{
					HoveredLayerOverVis = true;
					GLContext.Invalidate();
				}
				else
				{
					HoveredLayerOverVis = false;
					GLContext.Invalidate();
				}
			}
		}

		public void MouseUp(Point Location, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				if (IsDraggingKeyframe && KeyframeDragStartTime != SelectedKeyframe.Time)
					Program.Form_Main.Do(new KeyframeMoveAction(SelectedLayer, SelectedFrameset, SelectedKeyframe, KeyframeDragStartTime));
				else if (IsDraggingFrameset && FramesetDragStartTime != SelectedFrameset.Keyframes[0].Time)
					Program.Form_Main.Do(new FramesetMoveAction(SelectedLayer, SelectedFrameset, (int)FramesetDragStartTime, (int)SelectedFrameset.Keyframes[0].Time));
			}

			if (Location.X > SplitterDistance && Location.Y < (Program.ActiveProject.Layers.Count * 16) + 16 &&
				Location.Y > 16 &&
				button == MouseButtons.Right &&
				!IsPlaying())
				Program.Form_Main.Form_Timeline.ShowFrameCxtMenu(Location, GetFrameType(), (int)FrameNum);
			else if (Location.Y < (Program.ActiveProject.Layers.Count * 16) + 16 && Location.Y > 16 && button == MouseButtons.Right &&
				!IsPlaying())
			{
				Program.Form_Timeline.ShowLayerCxtMenu(Location, 0);
			}

			IsMouseDown = false;
			IsDragging = false;
			IsDraggingKeyframe = false;
			IsDraggingFrameset = false;
			IsDraggingSplitter = false;

			GLContext.Invalidate();
		}

		public void MouseLeft()
		{
			IsDragging = false;
			GLContext.Invalidate();
		}
		#endregion

		#region Actions
		public void InsertKeyframe(bool currentPose = false)
		{
			if (SelectedLayer == null || SelectedFrameset == null)
				return;

			Keyframe prev = null;
			Keyframe next = null;

			uint TargetTime = (uint)FrameNum;

			for (int i = 0; i < SelectedFrameset.Keyframes.Count; i++)
			{
				if (SelectedFrameset.Keyframes[i].Time < TargetTime)
					if (SelectedFrameset.Keyframes[i + 1] != null)
						if (SelectedFrameset.Keyframes[i + 1].Time > TargetTime)
						{
							// If there isn't a keyframe after this, something has gone horribly wrong, abort!
							if (i + 1 >= SelectedFrameset.Keyframes.Count)
								return;

							prev = SelectedFrameset.Keyframes[i];
							next = SelectedFrameset.Keyframes[i + 1];
							break;
						}
			}

			if (prev == null || next == null)
				return;

			// Add the new frame in an interpolated form between its neighbouring keyframes.
			float interpolationAmount = 0.0f;

            if (currentPose)
				interpolationAmount = (TargetTime - prev.Time) / (float)(next.Time - prev.Time);

			Program.Form_Main.Do(new KeyframeAddAction(SelectedLayer, SelectedFrameset, TargetTime, prev.State.Copy(), next.State.Copy(), interpolationAmount));
		}

		public void RemoveKeyframe()
		{
			if (SelectedKeyframe == null)
				return;

			Program.Form_Main.Do(new KeyframeRemoveAction(SelectedLayer, SelectedFrameset, SelectedKeyframe));

			GLContext.Invalidate();
		}

		public void SetPoseToPrevious()
		{
			if (SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) < 1)
				return;

			Program.Form_Main.Do(new ManipulatableUpdateAction(SelectedLayer, SelectedFrameset, SelectedKeyframe, SelectedKeyframe.State, SelectedFrameset.Keyframes[SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) - 1].State));
		}

		public void SetPoseToNext()
		{
			if (SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) == SelectedFrameset.Keyframes.Count - 1)
				return;

			Program.Form_Main.Do(new ManipulatableUpdateAction(SelectedLayer, SelectedFrameset, SelectedKeyframe, SelectedKeyframe.State, SelectedFrameset.Keyframes[SelectedFrameset.Keyframes.IndexOf(SelectedKeyframe) + 1].State));
		}

		public bool CanInsertFrameset()
		{
			if (!selectedItems.Contains(SelectionType.NullFrame) || SelectedLayer.Type != LayerTypeEnum.Entity)
				return false;

			if (selectedTime > SelectedLayer.Framesets[SelectedLayer.Framesets.Count - 1].EndTime)
				return true;
			else
			{
				float nextTime = -1;

				foreach (Frameset fs in SelectedLayer.Framesets)
				{
					if (fs.EndTime < selectedTime)
						continue;

					nextTime = fs.StartTime;
					break;
				}

				if (nextTime > -1 && nextTime >= selectedTime + 2)
					return true;
			}

			return false;
		}

		public void InsertFrameset()
		{
			if (!Program.MainTimeline.CanInsertFrameset())
				return;

			Program.Form_Main.Do(new FramesetAddAction(SelectedLayer));
		}

		public void RemoveFrameset()
		{
			Program.Form_Main.Do(new FramesetRemoveAction(SelectedLayer, SelectedFrameset));
			selectedItems.Clear(SelectionType.Frameset);
		}

		public void MoveLayerUp()
		{
			if (SelectedLayer == null)
				return;

			if (SelectedLayer.Data.GetType() == typeof(Camera))
				return;

			if (Program.ActiveProject.Layers.IndexOf(SelectedLayer) > 1)
				Program.Form_Main.Do(new LayerMoveUpAction(SelectedLayer));
		}

		public void MoveLayerDown()
		{
			if (SelectedLayer == null)
				return;

			if (SelectedLayer.Data.GetType() == typeof(Camera))
				return;

			if(Program.ActiveProject.Layers.IndexOf(SelectedLayer) < Program.ActiveProject.Layers.Count - 1)
				Program.Form_Main.Do(new LayerMoveDownAction(SelectedLayer));
		}

		public void RemoveLayer()
		{
			if (SelectedLayer != null && SelectedLayer.Data.GetType() != typeof(Camera))
				if (Program.ActiveProject.Layers.IndexOf(SelectedLayer) != -1)
					Program.Form_Main.Do(new LayerRemoveAction(SelectedLayer));

			selectedItems.Clear();
		}

		public void RenameLayer(string name)
		{
			if (HoveredLayerIndex != -1)
			{
				Program.ActiveProject.Layers[HoveredLayerIndex].Name = name;
				GLContext.Invalidate();
			}
		}

		public void AddLayerGroup(string name)
		{
			if (HoveredLayerIndex != -1)
			{
				Layer layer = new Layer(Program.ActiveProject.Layers[HoveredLayerIndex], Program.ActiveProject.Layers[HoveredLayerIndex].Depth);

				layer.Name = name;

				Program.ActiveProject.Layers.RemoveAt(HoveredLayerIndex);
				Program.ActiveProject.Layers.Insert(HoveredLayerIndex, layer);
				GLContext.Invalidate();
			}
		}

		public void ChangeInterpolationMode(EntityInterpolationMode mode)
		{
			if (SelectedKeyframe != null)
				Program.Form_Main.Do(new KeyframeChangeInterpModeAction(SelectedLayer, SelectedFrameset, SelectedKeyframe, mode));
		} 
		#endregion
	}
}
