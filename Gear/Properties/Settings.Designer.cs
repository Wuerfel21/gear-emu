﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Gear.Properties
{
    [CompilerGeneratedAttribute()]
    [GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("")]
        [CategoryAttribute("Plugin Editor")]
        [DescriptionAttribute("Last plugin loaded or edited (with full path).")]
        [DisplayNameAttribute("last Plugin loaded")]
        public string LastPlugin {
            get {
                return ((string)(this["LastPlugin"]));
            }
            set {
                this["LastPlugin"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("")]
        [CategoryAttribute("Propeller Emulator")]
        [DescriptionAttribute("Last Propeller binary loaded (with full path).")]
        [DisplayNameAttribute("Last Binary loaded")]
        public string LastBinary {
            get {
                return ((string)(this["LastBinary"]));
            }
            set {
                this["LastBinary"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("True")]
        [CategoryAttribute("Plugin Editor")]
        [DescriptionAttribute("Use a template for new plugins")]
        [DisplayNameAttribute("Use template for new plugins")]
        [ReadOnlyAttribute(true)]
        public bool UseTemplate {
            get {
                return ((bool)(this["UseTemplate"]));
            }
            set {
                this["UseTemplate"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("1024")]
        [CategoryAttribute("Propeller Emulator")]
        [DescriptionAttribute("How many clock steps will pass between screen repaint of emulator and plugins.")]
        [DisplayNameAttribute("Update screen each steps")]
        public uint UpdateEachSteps {
            get {
                return ((uint)(this["UpdateEachSteps"]));
            }
            set {
                this["UpdateEachSteps"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("1E-04")]
        [CategoryAttribute("Logic Probe")]
        [DescriptionAttribute("Width of time frame for the logic probe window.")]
        [DisplayNameAttribute("Last Time Frame")]
        public double LastTimeFrame {
            get {
                return ((double)(this["LastTimeFrame"]));
            }
            set {
                this["LastTimeFrame"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("5E-05")]
        [CategoryAttribute("Logic Probe")]
        [DescriptionAttribute("Time interval for the logic probe grid.")]
        [DisplayNameAttribute("Last Tick mark Grid")]
        public double LastTickMarkGrid {
            get {
                return ((double)(this["LastTickMarkGrid"]));
            }
            set {
                this["LastTickMarkGrid"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("True")]
        [CategoryAttribute("Plugin Editor")]
        [DescriptionAttribute("Flag to embed the C# code of the plugin into XML file, or to " + 
            "create in a separated .CS file.")]
        [DisplayNameAttribute("Embedded code?")]
        public bool EmbeddedCode {
            get {
                return ((bool)(this["EmbeddedCode"]));
            }
            set {
                this["EmbeddedCode"] = value;
            }
        }
        
        [UserScopedSettingAttribute()]
        [DebuggerNonUserCodeAttribute()]
        [DefaultSettingValueAttribute("4")]
        [CategoryAttribute("Plugin Editor")]
        [DescriptionAttribute("Tabulator size in characters.")]
        [DisplayNameAttribute("Tab size")]
        public uint TabSize {
            get {
                return ((uint)(this["TabSize"]));
            }
            set {
                this["TabSize"] = value;
            }
        }
    }
}
