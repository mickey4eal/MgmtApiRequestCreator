﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementApi.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ApiRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApiRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ManagementApi.Resources.ApiRequests", typeof(ApiRequests).Assembly);
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
        ///   Looks up a localized string similar to SOAP Request Generator Started\n.
        /// </summary>
        internal static string IntroCommandPromptMsg {
            get {
                return ResourceManager.GetString("IntroCommandPromptMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;soapenv:Envelope xmlns:soapenv=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; xmlns:man=&quot;http://christies.perfectchannel.com/2017/01/ManagementAPI/&quot; xmlns:lot=&quot;http://christies.perfectchannel.com/2017/01/ManagementAPI/Lot/&quot; xmlns:arr=&quot;http://schemas.microsoft.com/2003/10/Serialization/Arrays&quot; xmlns:sys=&quot;http://schemas.datacontract.org/2004/07/System&quot;&gt;
        ///   &lt;soapenv:Header/&gt;
        ///   &lt;soapenv:Body&gt;
        ///      &lt;man:CreateOrUpdateLot&gt;
        ///         &lt;!--Optional:--&gt;
        ///         &lt;man:request&gt;
        ///            &lt;!--Optional:--&gt;
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LotItemSoapUIRequestTemplate {
            get {
                return ResourceManager.GetString("LotItemSoapUIRequestTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;lot:LotTranslation&gt;
        ///                  &lt;lot:ArtistMaker&gt;{0}&lt;/lot:ArtistMaker&gt;
        ///                  &lt;!--Optional:--&gt;
        ///                  &lt;lot:ConditionReport&gt;{1}&lt;/lot:ConditionReport&gt;
        ///                  &lt;!--Optional:--&gt;
        ///                  &lt;lot:Description&gt;{2}&lt;/lot:Description&gt;
        ///                  &lt;!--Optional:--&gt;
        ///                  &lt;lot:Engraved&gt;{3}&lt;/lot:Engraved&gt;
        ///                  &lt;!--Optional:--&gt;
        ///                  &lt;lot:Exhibited&gt;{4}&lt;/lot:Exhibited&gt;
        ///                  &lt;!--Optional:--&gt;
        ///                  &lt;lot [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LotTranslationTemplate {
            get {
                return ResourceManager.GetString("LotTranslationTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \nPlease enter a valid ItemId e.g. 456789 to Generator Management API Request Template for Lot\nTo End Process, Enter Exit or Ex.
        /// </summary>
        internal static string RequestInputPromptMsgLot {
            get {
                return ResourceManager.GetString("RequestInputPromptMsgLot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \nPlease enter a valid SaleId e.g. 1234 to Generator Management API Request Template for Sale\nTo End Process, Enter Exit or Ex.
        /// </summary>
        internal static string RequestInputPromptMsgSale {
            get {
                return ResourceManager.GetString("RequestInputPromptMsgSale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;soapenv:Envelope xmlns:soapenv=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; xmlns:man=&quot;http://christies.perfectchannel.com/2017/01/ManagementAPI/&quot; xmlns:sale=&quot;http://christies.perfectchannel.com/2017/01/ManagementAPI/Sale/&quot; xmlns:sys=&quot;http://schemas.datacontract.org/2004/07/System&quot;&gt;
        ///	&lt;soapenv:Header/&gt;
        ///	&lt;soapenv:Body&gt;
        ///		&lt;man:SaleCreateOrUpdate&gt;
        ///			&lt;man:request&gt;
        ///				
        ///				&lt;sale:AnalyticsSaleType&gt;{16}&lt;/sale:AnalyticsSaleType&gt;
        ///				&lt;sale:ApplicationCorrelationId&gt;b5954a0d-8115-49ae-99da-ead4c17577c7&lt;/sale:A [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SoapUIRequestTemplate {
            get {
                return ResourceManager.GetString("SoapUIRequestTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To Generate SOAP Request for a Sale, Please enter &apos;s&apos; or &apos;sale&apos;\nTo Generate SOAP Request for a lot, Please enter &apos;l&apos; or &apos;lot&apos;\nTo End Process, Enter Exit or Ex.
        /// </summary>
        internal static string StandardCommandPromptMsg {
            get {
                return ResourceManager.GetString("StandardCommandPromptMsg", resourceCulture);
            }
        }
    }
}
