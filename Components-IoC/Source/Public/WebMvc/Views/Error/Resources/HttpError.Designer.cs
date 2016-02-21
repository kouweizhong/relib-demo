﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Public.WebMvc.Views.Error.Resources {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    public class HttpError {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HttpError() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("Public.WebMvc.Views.Error.Resources.HttpError", typeof(HttpError).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server was unable to process your request due to possible session termination..
        /// </summary>
        public static string DescriptionAntiForgery {
            get {
                return ResourceManager.GetString("DescriptionAntiForgery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The 400 Bad Request error is an HTTP status code that means that the request you sent to the website server (i.e. a request to load a web page) was somehow malformed therefore the server was unable to understand or process the request..
        /// </summary>
        public static string DescriptionHttp400 {
            get {
                return ResourceManager.GetString("DescriptionHttp400", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not have permission to view this directory or page using the credentials that you supplied..
        /// </summary>
        public static string DescriptionHttp403 {
            get {
                return ResourceManager.GetString("DescriptionHttp403", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unfortunately the page you are looking for may have been removed, had its name changed, under construction or is temporarily unavailable. Try checking the web address for typos, please. We apologize for the inconvenience..
        /// </summary>
        public static string DescriptionHttp404 {
            get {
                return ResourceManager.GetString("DescriptionHttp404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The web server encountered an unexpected condition that prevented it from fulfilling the request by the client for access to the requested URL..
        /// </summary>
        public static string DescriptionHttp500 {
            get {
                return ResourceManager.GetString("DescriptionHttp500", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One of your ip addresses does not match site policy. That prevents you from accessing our service..
        /// </summary>
        public static string DescriptionIpPolicy {
            get {
                return ResourceManager.GetString("DescriptionIpPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have reached the maximum quota limit for incoming requests. Please try again later once the limit is reset for you..
        /// </summary>
        public static string DescriptionLimitExceeded {
            get {
                return ResourceManager.GetString("DescriptionLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server was unable to process your request due to detected forbidden value. Please try to avoid using the &quot;&amp;lt;&quot; character and/or a character combination of &quot;&amp;amp;#&quot; within the URL and/or form values. Please check your request and try again..
        /// </summary>
        public static string DescriptionRequestValidation {
            get {
                return ResourceManager.GetString("DescriptionRequestValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Anti forgery error.&lt;/strong&gt; Sorry, we can&apos;t process your request..
        /// </summary>
        public static string HeaderAntiForgery {
            get {
                return ResourceManager.GetString("HeaderAntiForgery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 400.&lt;/strong&gt; Sorry, we can&apos;t process your request..
        /// </summary>
        public static string HeaderHttp400 {
            get {
                return ResourceManager.GetString("HeaderHttp400", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 403.&lt;/strong&gt; Access is denied..
        /// </summary>
        public static string HeaderHttp403 {
            get {
                return ResourceManager.GetString("HeaderHttp403", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 404.&lt;/strong&gt; Sorry, we can&apos;t find that page..
        /// </summary>
        public static string HeaderHttp404 {
            get {
                return ResourceManager.GetString("HeaderHttp404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 500.&lt;/strong&gt; Sorry, we can&apos;t process your request..
        /// </summary>
        public static string HeaderHttp500 {
            get {
                return ResourceManager.GetString("HeaderHttp500", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 403.&lt;/strong&gt; IP Policy..
        /// </summary>
        public static string HeaderIpPolicy {
            get {
                return ResourceManager.GetString("HeaderIpPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Code 403.&lt;/strong&gt; Quota Exceeded..
        /// </summary>
        public static string HeaderLimitExceeded {
            get {
                return ResourceManager.GetString("HeaderLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;strong&gt;Oops! Request validation error.&lt;/strong&gt; Sorry, we can&apos;t process your request..
        /// </summary>
        public static string HeaderRequestValidation {
            get {
                return ResourceManager.GetString("HeaderRequestValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request antiforgery error.
        /// </summary>
        public static string TitleAntiForgery {
            get {
                return ResourceManager.GetString("TitleAntiForgery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad request.
        /// </summary>
        public static string TitleHttp400 {
            get {
                return ResourceManager.GetString("TitleHttp400", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied.
        /// </summary>
        public static string TitleHttp403 {
            get {
                return ResourceManager.GetString("TitleHttp403", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We are sorry, the page you requested cannot be found..
        /// </summary>
        public static string TitleHttp404 {
            get {
                return ResourceManager.GetString("TitleHttp404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We are sorry, we can&apos;t process your request..
        /// </summary>
        public static string TitleHttp500 {
            get {
                return ResourceManager.GetString("TitleHttp500", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request validation error.
        /// </summary>
        public static string TitleRequestValidation {
            get {
                return ResourceManager.GetString("TitleRequestValidation", resourceCulture);
            }
        }
    }
}
