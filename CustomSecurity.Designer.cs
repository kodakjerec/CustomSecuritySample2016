﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.ReportingServices.CustomSecurity {
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
    internal class CustomSecurity {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomSecurity() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Samples.ReportingServices.CustomSecurity.CustomSecurity", typeof(CustomSecurity).Assembly);
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
        ///   Looks up a localized string similar to An error occurred while attempting to add the account. .
        /// </summary>
        internal static string AddAccountError {
            get {
                return ResourceManager.GetString("AddAccountError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root element is not \&quot;AdminConfiguration\&quot; in config data..
        /// </summary>
        internal static string AdminConfiguration {
            get {
                return ResourceManager.GetString("AdminConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Url reservation found for the \&quot;ReportServerWebService\&quot; application..
        /// </summary>
        internal static string MissingUrlReservation {
            get {
                return ResourceManager.GetString("MissingUrlReservation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of operation names don&apos;t match..
        /// </summary>
        internal static string OperationNameError {
            get {
                return ResourceManager.GetString("OperationNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while attempting to get the ReportServer Url. .
        /// </summary>
        internal static string RSUrlError {
            get {
                return ResourceManager.GetString("RSUrlError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized configuration element..
        /// </summary>
        internal static string UnrecognizedElement {
            get {
                return ResourceManager.GetString("UnrecognizedElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  user registered.
        /// </summary>
        internal static string UserRegistered {
            get {
                return ResourceManager.GetString("UserRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception verifying user. .
        /// </summary>
        internal static string VerifyError {
            get {
                return ResourceManager.GetString("VerifyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while attempting to verify the user..
        /// </summary>
        internal static string VerifyUserException {
            get {
                return ResourceManager.GetString("VerifyUserException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WMI class found..
        /// </summary>
        internal static string WMIClassError {
            get {
                return ResourceManager.GetString("WMIClassError", resourceCulture);
            }
        }
    }
}
