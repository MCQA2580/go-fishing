﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenshinAutoFish.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point StrainBarAreaLocation {
            get {
                return ((global::System.Drawing.Point)(this["StrainBarAreaLocation"]));
            }
            set {
                this["StrainBarAreaLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("599, 50")]
        public global::System.Drawing.Size StrainBarAreaSize {
            get {
                return ((global::System.Drawing.Size)(this["StrainBarAreaSize"]));
            }
            set {
                this["StrainBarAreaSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point FormMainLocation {
            get {
                return ((global::System.Drawing.Point)(this["FormMainLocation"]));
            }
            set {
                this["FormMainLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TopMostChecked {
            get {
                return ((bool)(this["TopMostChecked"]));
            }
            set {
                this["TopMostChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public decimal FrameRate {
            get {
                return ((decimal)(this["FrameRate"]));
            }
            set {
                this["FrameRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoPullUpChecked {
            get {
                return ((bool)(this["AutoPullUpChecked"]));
            }
            set {
                this["AutoPullUpChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayDetectChecked {
            get {
                return ((bool)(this["DisplayDetectChecked"]));
            }
            set {
                this["DisplayDetectChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AlwaysHideAreaChecked {
            get {
                return ((bool)(this["AlwaysHideAreaChecked"]));
            }
            set {
                this["AlwaysHideAreaChecked"] = value;
            }
        }
    }
}
