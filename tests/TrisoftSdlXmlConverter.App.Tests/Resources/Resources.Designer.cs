﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrisoftSdlXmlConverter.App.Tests.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrisoftSdlXmlConverter.App.Tests.Resources.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;html&gt;
        ///    &lt;head title=&quot;@!Trisoft!!@ makes perfect!&quot;&gt;SDL is so-o-o good!&lt;/head&gt;
        ///    &lt;body title=&quot;Body should not contain title | Trisoft&quot;&gt;
        ///        &lt;h1&gt;Trisoft will be replaced soon by SDL Trisoft&lt;/h1&gt;
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string _001_no_namespace {
            get {
                return ResourceManager.GetString("_001_no_namespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;html xmlns:html4=&quot;http://www.w3.org/TR/html4&quot;&gt;
        ///    &lt;head title=&quot;@!SDL Trisoft!!@ makes perfect!&quot;&gt;SDL is so-o-o good!&lt;/head&gt;
        ///    &lt;body title=&quot;Body should not contain title | SDL Trisoft&quot;&gt;
        ///        &lt;h1&gt;SDL Trisoft will be replaced soon by SDL Trisoft&lt;/h1&gt;
        ///    &lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string _001_no_namespace_expected {
            get {
                return ResourceManager.GetString("_001_no_namespace_expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;html xmlns:html4=&quot;http://www.w3.org/TR/html4&quot;&gt;
        ///    &lt;html4:head title=&quot;@!Trisoft!!@ makes perfect!&quot;&gt;SDL is so-o-o good!&lt;/html4:head&gt;
        ///    &lt;html4:body title=&quot;Body should not contain title | Trisoft&quot;&gt;
        ///        &lt;html4:h1&gt;Trisoft will be replaced soon by SDL Trisoft&lt;/html4:h1&gt;
        ///    &lt;/html4:body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string _002_single_namespace {
            get {
                return ResourceManager.GetString("_002_single_namespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;html xmlns:html4=&quot;http://www.w3.org/TR/html4&quot;&gt;
        ///    &lt;html4:head title=&quot;@!SDL Trisoft!!@ makes perfect!&quot;&gt;SDL is so-o-o good!&lt;/html4:head&gt;
        ///    &lt;html4:body title=&quot;Body should not contain title | SDL Trisoft&quot;&gt;
        ///        &lt;html4:h1&gt;SDL Trisoft will be replaced soon by SDL Trisoft&lt;/html4:h1&gt;
        ///    &lt;/html4:body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string _002_single_namespace_expected {
            get {
                return ResourceManager.GetString("_002_single_namespace_expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;root xmlns:h=&quot;http://www.w3.org/TR/html4&quot; xmlns:f=&quot;https://www.w3schools.com/furniture&quot;&gt;
        ///    &lt;h:table&gt;
        ///        &lt;h:tr&gt;
        ///            &lt;h:td title=&quot;How about making better Trisoft?&quot;&gt;Trisoft&lt;/h:td&gt;
        ///            &lt;h:td title=&quot;It&apos;s a trisoft term in a lower register. Should it be replaced?&quot;&gt;SDL&lt;/h:td&gt;
        ///        &lt;/h:tr&gt;
        ///    &lt;/h:table&gt;
        ///
        ///    &lt;f:table title=&quot;trisoft or Trisoft? I know the answer&quot;&gt;
        ///        &lt;f:name&gt;It could be SDL&lt;/f:name&gt;
        ///        &lt;f:width&gt;Maybe, it&apos;s TRisoF [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_multiple_namespaces {
            get {
                return ResourceManager.GetString("_003_multiple_namespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;root xmlns:h=&quot;http://www.w3.org/TR/html4&quot; xmlns:f=&quot;https://www.w3schools.com/furniture&quot;&gt;
        ///    &lt;h:table&gt;
        ///        &lt;h:tr&gt;
        ///            &lt;h:td title=&quot;How about making better SDL Trisoft?&quot; style=&quot;Should Trisoft also be replaced here? Nope!&quot;&gt;SDL Trisoft&lt;/h:td&gt;
        ///            &lt;h:td title=&quot;It&apos;s a trisoft term in a lower register. Should it be replaced?&quot;&gt;SDL&lt;/h:td&gt;
        ///        &lt;/h:tr&gt;
        ///    &lt;/h:table&gt;
        ///
        ///    &lt;f:table title=&quot;trisoft or SDL Trisoft? I know the answer&quot;&gt;
        ///        &lt;f:na [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_multiple_namespaces_expected {
            get {
                return ResourceManager.GetString("_003_multiple_namespaces_expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;&gt;
        ///    &lt;xsl:template match=&quot;/&quot;&gt;
        ///        &lt;html title=&quot;Trisoft&quot;&gt;
        ///            &lt;body&gt;
        ///                &lt;h2&gt;My CD Collection&lt;/h2&gt;
        ///                &lt;table border=&quot;1&quot;&gt;
        ///                    &lt;tr title=&quot;Trisoft&quot;&gt;
        ///                        &lt;th style=&quot;text-align:left&quot;&gt;Trisoft&lt;/th&gt;
        ///                        &lt;th style=&quot;text-align:left&quot;&gt;SDL&lt;/th&gt;
        ///                    &lt;/tr&gt;
        ///                    &lt;xsl:for-each [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _004_xsl_single_namespace {
            get {
                return ResourceManager.GetString("_004_xsl_single_namespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;&gt;
        ///    &lt;xsl:template match=&quot;/&quot;&gt;
        ///        &lt;html title=&quot;SDL Trisoft&quot;&gt;
        ///            &lt;body&gt;
        ///                &lt;h2&gt;My CD Collection&lt;/h2&gt;
        ///                &lt;table border=&quot;1&quot;&gt;
        ///                    &lt;tr title=&quot;SDL Trisoft&quot;&gt;
        ///                        &lt;th style=&quot;text-align:left&quot;&gt;SDL Trisoft&lt;/th&gt;
        ///                        &lt;th style=&quot;text-align:left&quot;&gt;SDL&lt;/th&gt;
        ///                    &lt;/tr&gt;
        ///                    &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _004_xsl_single_namespace_expected {
            get {
                return ResourceManager.GetString("_004_xsl_single_namespace_expected", resourceCulture);
            }
        }
    }
}