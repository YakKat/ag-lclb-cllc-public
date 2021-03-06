// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMpluginassembly
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly(string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), int? componentstate = default(int?), string content = default(string), string contentBinary = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string culture = default(string), int? customizationlevel = default(int?), string description = default(string), string introducedversion = default(string), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty ishidden = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? ismanaged = default(bool?), int? isolationmode = default(int?), int? major = default(int?), int? minor = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string path = default(string), IList<MicrosoftDynamicsCRMplugintype> pluginassemblyPlugintype = default(IList<MicrosoftDynamicsCRMplugintype>), string pluginassemblyid = default(string), string pluginassemblyidunique = default(string), string publickeytoken = default(string), string solutionid = default(string), string sourcehash = default(string), int? sourcetype = default(int?), string version = default(string), object versionnumber = default(object))
        {
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Componentstate = componentstate;
            Content = content;
            ContentBinary = contentBinary;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Culture = culture;
            Customizationlevel = customizationlevel;
            Description = description;
            Introducedversion = introducedversion;
            Iscustomizable = iscustomizable;
            Ishidden = ishidden;
            Ismanaged = ismanaged;
            Isolationmode = isolationmode;
            Major = major;
            Minor = minor;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            Overwritetime = overwritetime;
            Path = path;
            PluginassemblyPlugintype = pluginassemblyPlugintype;
            Pluginassemblyid = pluginassemblyid;
            Pluginassemblyidunique = pluginassemblyidunique;
            Publickeytoken = publickeytoken;
            Solutionid = solutionid;
            Sourcehash = sourcehash;
            Sourcetype = sourcetype;
            Version = version;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_binary")]
        public string ContentBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isolationmode")]
        public int? Isolationmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public int? Major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public int? Minor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassembly_plugintype")]
        public IList<MicrosoftDynamicsCRMplugintype> PluginassemblyPlugintype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyid")]
        public string Pluginassemblyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyidunique")]
        public string Pluginassemblyidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publickeytoken")]
        public string Publickeytoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcehash")]
        public string Sourcehash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcetype")]
        public int? Sourcetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
