﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TISFAT_ZERO.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class User : global::System.Configuration.ApplicationSettingsBase {
        
        private static User defaultInstance = ((User)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new User())));
        
        public static User Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%userprofile%\\My Documents\\TISFAT")]
        public string DefaultSavePath {
            get {
                return ((string)(this["DefaultSavePath"]));
            }
            set {
                this["DefaultSavePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("460, 360")]
        public global::System.Drawing.Size CanvasSize {
            get {
                return ((global::System.Drawing.Size)(this["CanvasSize"]));
            }
            set {
                this["CanvasSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color CanvasColor {
            get {
                return ((global::System.Drawing.Color)(this["CanvasColor"]));
            }
            set {
                this["CanvasColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool autoCheck {
            get {
                return ((bool)(this["autoCheck"]));
            }
            set {
                this["autoCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string buildsInstalled {
            get {
                return ((string)(this["buildsInstalled"]));
            }
            set {
                this["buildsInstalled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string buildLocations {
            get {
                return ((string)(this["buildLocations"]));
            }
            set {
                this["buildLocations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string selectedBuilds {
            get {
                return ((string)(this["selectedBuilds"]));
            }
            set {
                this["selectedBuilds"] = value;
            }
        }
    }
}
