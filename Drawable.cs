﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NewKeyFrames
{
	interface IDrawable
	{
		void drawGraphics(int type, Color color, Point one, int width, int height, Point two);
	}
}
