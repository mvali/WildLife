﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class WebsiteVariables {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WebsiteVariables() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.WebsiteVariables", typeof(WebsiteVariables).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to admin@softwaredev.ro.
        /// </summary>
        public static string EmailAdministrator {
            get {
                return ResourceManager.GetString("EmailAdministrator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello Admin&lt;br /&gt;&lt;br /&gt;
        ///The following message was posted from website contact-us page:&lt;br /&gt;
        ///Name: (%NAME%)&lt;br /&gt;
        ///Email: (%EMAIL%)&lt;br /&gt;
        ///Message: (%MESSAGE%)&lt;br /&gt;
        ///&lt;br /&gt;
        ///Tracking info:&lt;br /&gt;
        ///IP: (%IP%)&lt;br /&gt;
        ///Referrer: (%REFERRER%)
        ///&lt;br /&gt;&lt;br /&gt;
        ///SoftwareDev Team.
        /// </summary>
        public static string EmailContactBody {
            get {
                return ResourceManager.GetString("EmailContactBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email from Contact Us page Wildlife.
        /// </summary>
        public static string EmailContactSubject {
            get {
                return ResourceManager.GetString("EmailContactSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to admin@softwaredev.ro.
        /// </summary>
        public static string EmailFromEmail {
            get {
                return ResourceManager.GetString("EmailFromEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MVC Website ValentinCostin.
        /// </summary>
        public static string EmailFromName {
            get {
                return ResourceManager.GetString("EmailFromName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to vali.my@gmail.com.
        /// </summary>
        public static string EmailTestAddress {
            get {
                return ResourceManager.GetString("EmailTestAddress", resourceCulture);
            }
        }
    }
}
