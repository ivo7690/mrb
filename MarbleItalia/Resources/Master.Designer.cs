﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarbleItalia.Resources {
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
    public class Master {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Master() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarbleItalia.Resources.Master", typeof(Master).Assembly);
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
        ///   Looks up a localized string similar to &lt;body bgcolor=&quot;#EDEDED&quot; leftmargin=&quot;0&quot; topmargin=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot;&gt;
        ///    &lt;table width=&quot;758&quot; border=&quot;0&quot; cellpadding=&quot;0&quot; cellspacing=&quot;0&quot; align=&quot;center&quot; style=&quot;margin: 25px auto 0;background:#ffffff;&quot;&gt;
        ///        &lt;tr style=&quot;background:#333&quot;&gt;
        ///            &lt;td style=&quot;padding:15px 25px 15px 25px;&quot;&gt;
        ///                &lt;p style=&quot;color:#FFFFFF;text-align:left;font:bold 27px Arial, Helvetica, sans-serif;&quot;&gt;
        ///                  New contact from website
        ///                &lt;/p&gt;
        ///            &lt;/td&gt;
        ///        &lt;/t [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ContactformMailTemplate {
            get {
                return ResourceManager.GetString("ContactformMailTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;body bgcolor=&quot;#EDEDED&quot; leftmargin=&quot;0&quot; topmargin=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot;&gt;
        ///    &lt;table width=&quot;758&quot; border=&quot;0&quot; cellpadding=&quot;0&quot; cellspacing=&quot;0&quot; align=&quot;center&quot; style=&quot;margin: 25px auto 0;background:#ffffff;&quot;&gt;
        ///        &lt;tr style=&quot;background:#333&quot;&gt;
        ///            &lt;td style=&quot;padding:20px 20px 20px 20px&quot;&gt;
        ///                &lt;a href=&quot;http://mrbitalia.com&quot; title=&quot;Marble Italia&quot; target=&quot;_blank&quot; style=&quot;text-decoration:none&quot;&gt;
        ///                    &lt;img src=&quot;http://mrbitalia.com/Images/logo-marbleitalia.png&quot; alt= [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FeedbackMailTemplate {
            get {
                return ResourceManager.GetString("FeedbackMailTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;body bgcolor=&quot;#EDEDED&quot; leftmargin=&quot;0&quot; topmargin=&quot;0&quot; marginwidth=&quot;0&quot; marginheight=&quot;0&quot;&gt;
        ///        &lt;table width=&quot;758&quot; border=&quot;0&quot; cellpadding=&quot;0&quot; cellspacing=&quot;0&quot; align=&quot;center&quot; style=&quot;margin: 25px auto 0;background:#ffffff;&quot;&gt;
        ///            &lt;tr style=&quot;background:#333&quot;&gt;
        ///                &lt;td style=&quot;padding:15px 25px 15px 25px;&quot;&gt;
        ///                    &lt;p style=&quot;color:#FFFFFF;text-align:left;font:bold 27px Arial, Helvetica, sans-serif;&quot;&gt;
        ///                        New request quote from mrbitalia.com
        ///                   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string QuoteMailTemplate {
            get {
                return ResourceManager.GetString("QuoteMailTemplate", resourceCulture);
            }
        }
    }
}