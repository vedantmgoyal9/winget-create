//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.4.3.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Microsoft.WingetCreateCore.Models.Locale
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Agreement 
    {
        /// <summary>The label of the Agreement. i.e. EULA, AgeRating, etc. This field should be localized. Either Agreement or AgreementUrl is required. When we show the agreements, we would Bold the AgreementLabel</summary>
        [Newtonsoft.Json.JsonProperty("AgreementLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string AgreementLabel { get; set; }
    
        /// <summary>The agreement text content.</summary>
        [Newtonsoft.Json.JsonProperty("Agreement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 1)]
        public string Agreement1 { get; set; }
    
        /// <summary>The agreement URL.</summary>
        [Newtonsoft.Json.JsonProperty("AgreementUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string AgreementUrl { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>A representation of a multiple-file manifest representing app metadata in other locale in the OWC. v1.1.0</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LocaleManifest 
    {
        /// <summary>The package unique identifier</summary>
        [Newtonsoft.Json.JsonProperty("PackageIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}(\.[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}){1,3}$")]
        public string PackageIdentifier { get; set; }
    
        /// <summary>The package version</summary>
        [Newtonsoft.Json.JsonProperty("PackageVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\\/:\*\?""<>\|\x01-\x1f]+$")]
        public string PackageVersion { get; set; }
    
        /// <summary>The package meta-data locale</summary>
        [Newtonsoft.Json.JsonProperty("PackageLocale", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([a-zA-Z]{2,3}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*$")]
        public string PackageLocale { get; set; }
    
        /// <summary>The publisher name</summary>
        [Newtonsoft.Json.JsonProperty("Publisher", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Publisher { get; set; }
    
        /// <summary>The publisher home page</summary>
        [Newtonsoft.Json.JsonProperty("PublisherUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherUrl { get; set; }
    
        /// <summary>The publisher support page</summary>
        [Newtonsoft.Json.JsonProperty("PublisherSupportUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherSupportUrl { get; set; }
    
        /// <summary>The publisher privacy page or the package privacy page</summary>
        [Newtonsoft.Json.JsonProperty("PrivacyUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PrivacyUrl { get; set; }
    
        /// <summary>The package author</summary>
        [Newtonsoft.Json.JsonProperty("Author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Author { get; set; }
    
        /// <summary>The package name</summary>
        [Newtonsoft.Json.JsonProperty("PackageName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string PackageName { get; set; }
    
        /// <summary>The package home page</summary>
        [Newtonsoft.Json.JsonProperty("PackageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PackageUrl { get; set; }
    
        /// <summary>The package license</summary>
        [Newtonsoft.Json.JsonProperty("License", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string License { get; set; }
    
        /// <summary>The license page</summary>
        [Newtonsoft.Json.JsonProperty("LicenseUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string LicenseUrl { get; set; }
    
        /// <summary>The package copyright</summary>
        [Newtonsoft.Json.JsonProperty("Copyright", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string Copyright { get; set; }
    
        /// <summary>The package copyright page</summary>
        [Newtonsoft.Json.JsonProperty("CopyrightUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string CopyrightUrl { get; set; }
    
        /// <summary>The short package description</summary>
        [Newtonsoft.Json.JsonProperty("ShortDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 3)]
        public string ShortDescription { get; set; }
    
        /// <summary>The full package description</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 3)]
        public string Description { get; set; }
    
        /// <summary>List of additional package search terms</summary>
        [Newtonsoft.Json.JsonProperty("Tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Tags { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Agreements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(128)]
        public System.Collections.Generic.List<Agreement> Agreements { get; set; }
    
        /// <summary>The package release notes</summary>
        [Newtonsoft.Json.JsonProperty("ReleaseNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 1)]
        public string ReleaseNotes { get; set; }
    
        /// <summary>The package release notes url</summary>
        [Newtonsoft.Json.JsonProperty("ReleaseNotesUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string ReleaseNotesUrl { get; set; }
    
        /// <summary>The manifest type</summary>
        [Newtonsoft.Json.JsonProperty("ManifestType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ManifestType { get; set; } = "locale";
    
        /// <summary>The manifest syntax version</summary>
        [Newtonsoft.Json.JsonProperty("ManifestVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(\.(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])){2}$")]
        public string ManifestVersion { get; set; } = "1.1.0";
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}