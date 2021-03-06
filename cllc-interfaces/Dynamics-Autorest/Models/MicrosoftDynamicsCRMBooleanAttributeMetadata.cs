// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMBooleanAttributeMetadata : MicrosoftDynamicsCRMAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanAttributeMetadata class.
        /// </summary>
        /// <param name="attributeType">Possible values include: 'Boolean',
        /// 'Customer', 'DateTime', 'Decimal', 'Double', 'Integer', 'Lookup',
        /// 'Memo', 'Money', 'Owner', 'PartyList', 'Picklist', 'State',
        /// 'Status', 'String', 'Uniqueidentifier', 'CalendarRules', 'Virtual',
        /// 'BigInt', 'ManagedProperty', 'EntityName'</param>
        public MicrosoftDynamicsCRMBooleanAttributeMetadata(bool? hasChanged = default(bool?), string metadataId = default(string), string attributeOf = default(string), string attributeType = default(string), MicrosoftDynamicsCRMAttributeTypeDisplayName attributeTypeName = default(MicrosoftDynamicsCRMAttributeTypeDisplayName), bool? canBeSecuredForCreate = default(bool?), bool? canBeSecuredForRead = default(bool?), bool? canBeSecuredForUpdate = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty canModifyAdditionalSettings = default(MicrosoftDynamicsCRMBooleanManagedProperty), int? columnNumber = default(int?), string deprecatedVersion = default(string), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string entityLogicalName = default(string), string inheritsFrom = default(string), string introducedVersion = default(string), MicrosoftDynamicsCRMBooleanManagedProperty isAuditEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isCustomAttribute = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isFilterable = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isGlobalFilterEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isLogical = default(bool?), bool? isManaged = default(bool?), bool? isPrimaryId = default(bool?), bool? isPrimaryName = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isRenameable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isRetrievable = default(bool?), bool? isSearchable = default(bool?), bool? isSecured = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isSortableEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isValidForAdvancedFind = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isValidForCreate = default(bool?), bool? isValidForRead = default(bool?), bool? isValidForUpdate = default(bool?), string linkedAttributeId = default(string), string logicalName = default(string), MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty requiredLevel = default(MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty), string schemaName = default(string), int? sourceType = default(int?), bool? defaultValue = default(bool?), string formulaDefinition = default(string), MicrosoftDynamicsCRMBooleanOptionSetMetadata globalOptionSet = default(MicrosoftDynamicsCRMBooleanOptionSetMetadata), MicrosoftDynamicsCRMBooleanOptionSetMetadata optionSet = default(MicrosoftDynamicsCRMBooleanOptionSetMetadata), int? sourceTypeMask = default(int?))
            : base(hasChanged, metadataId, attributeOf, attributeType, attributeTypeName, canBeSecuredForCreate, canBeSecuredForRead, canBeSecuredForUpdate, canModifyAdditionalSettings, columnNumber, deprecatedVersion, description, displayName, entityLogicalName, inheritsFrom, introducedVersion, isAuditEnabled, isCustomAttribute, isCustomizable, isFilterable, isGlobalFilterEnabled, isLogical, isManaged, isPrimaryId, isPrimaryName, isRenameable, isRetrievable, isSearchable, isSecured, isSortableEnabled, isValidForAdvancedFind, isValidForCreate, isValidForRead, isValidForUpdate, linkedAttributeId, logicalName, requiredLevel, schemaName, sourceType)
        {
            DefaultValue = defaultValue;
            FormulaDefinition = formulaDefinition;
            GlobalOptionSet = globalOptionSet;
            OptionSet = optionSet;
            SourceTypeMask = sourceTypeMask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValue")]
        public bool? DefaultValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GlobalOptionSet")]
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata GlobalOptionSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OptionSet")]
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata OptionSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

    }
}
