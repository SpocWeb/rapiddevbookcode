﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LLBLGen.EntityBrowser.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
            "True")]
        public string Connection0 {
            get {
                return ((string)(this["Connection0"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Jeremy Thomas\\Documents\\Visual Studio 2010\\Projects\\CodePlex\\RapidDevBoo" +
            "kCode\\LLBL Pro v4.2\\Northwind\\Northwind.Win\\bin\\Debug\\Northwind.DAL.SqlServer.dl" +
            "l")]
        public string AdapterAssemblyPath {
            get {
                return ((string)(this["AdapterAssemblyPath"]));
            }
            set {
                this["AdapterAssemblyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Jeremy Thomas\\Documents\\Visual Studio 2010\\Projects\\CodePlex\\RapidDevBoo" +
            "kCode\\LLBL Pro v4.2\\Northwind\\Northwind.Win\\bin\\Debug\\Northwind.DAL.dll")]
        public string LinqMetaDataAssemblyPath {
            get {
                return ((string)(this["LinqMetaDataAssemblyPath"]));
            }
            set {
                this["LinqMetaDataAssemblyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection Connections {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Connections"]));
            }
            set {
                this["Connections"] = value;
            }
        }
    }
}