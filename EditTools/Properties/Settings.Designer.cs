﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string mindist {
            get {
                return ((string)(this["mindist"]));
            }
            set {
                this["mindist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection boilerplate {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["boilerplate"]));
            }
            set {
                this["boilerplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English (Canada)")]
        public string lastlang {
            get {
                return ((string)(this["lastlang"]));
            }
            set {
                this["lastlang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public uint minphraselen {
            get {
                return ((uint)(this["minphraselen"]));
            }
            set {
                this["minphraselen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public uint maxphraselen {
            get {
                return ((uint)(this["maxphraselen"]));
            }
            set {
                this["maxphraselen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"double spaces\":{\"Find\":\"  \",\"Replace\":\" \",\"Wildcards\":false,\"CaseSensitive\":fal" +
            "se,\"ReplaceAll\":true}}")]
        public global::EditTools.Searches searches {
            get {
                return ((global::EditTools.Searches)(this["searches"]));
            }
            set {
                this["searches"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"{""(s)"":{""Text"":""Never use \""(s)\"". Both the federal and provincial interpretation acts stipulate that the singular can be read as the plural and vice versa.""},""and/or"":{""Text"":""Never use \""and/or.\"" If clarity is critical, use constructs like \""X or Y or both\"" or \""X or Y but not both.\"" That said, in normal usage, one or the other is sufficient. Saying \""No food or drink allowed\"" does not mean you can have both. Or saying \""Lawyers and law students may not enter\"" does not mean that any one of them may.""}}")]
        public global::EditTools.Boilerplate newboiler {
            get {
                return ((global::EditTools.Boilerplate)(this["newboiler"]));
            }
            set {
                this["newboiler"] = value;
            }
        }
    }
}
