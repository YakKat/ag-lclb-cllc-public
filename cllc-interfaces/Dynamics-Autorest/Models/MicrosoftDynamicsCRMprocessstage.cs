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

    public partial class MicrosoftDynamicsCRMprocessstage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage(IList<MicrosoftDynamicsCRMsyncerror> processStageSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _owneridValue = default(string), string _processidValue = default(string), string clientdata = default(string), IList<MicrosoftDynamicsCRMadoxioApplicationbpf> lkAdoxioApplicationbpfActivestageid = default(IList<MicrosoftDynamicsCRMadoxioApplicationbpf>), IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2> lkAdoxioApplicationbpfmvpv2Activestageid = default(IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2>), IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> lkAdoxioComplaintpublicbpfActivestageid = default(IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf>), IList<MicrosoftDynamicsCRMnewBpf839d33d7035a4f2bbe2150f27b500af6> lkNewBpf839d33d7035a4f2bbe2150f27b500af6Activestageid = default(IList<MicrosoftDynamicsCRMnewBpf839d33d7035a4f2bbe2150f27b500af6>), IList<MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2> lkNewBpfA5f48dac03e04d1498b374c0638698a2Activestageid = default(IList<MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2>), string owningbusinessunit = default(string), string primaryentitytypecode = default(string), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMaccount> processstageAccount = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMadoxioApplication> processstageAdoxioApplication = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioComplaint> processstageAdoxioComplaint = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMappointment> processstageAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMcampaignactivity> processstageCampaignactivities = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> processstageCampaignresponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMcampaign> processstageCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcompetitor> processstageCompetitors = default(IList<MicrosoftDynamicsCRMcompetitor>), IList<MicrosoftDynamicsCRMcontact> processstageContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMemail> processstageEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMexpiredprocess> processstageExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMfax> processstageFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMincident> processstageIncident = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMinvoice> processstageInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMknowledgearticle> processstageKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMlead> processstageLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> processstageLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess>), IList<MicrosoftDynamicsCRMletter> processstageLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMlist> processstageLists = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMnewprocess> processstageNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), IList<MicrosoftDynamicsCRMopportunity> processstageOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> processstageOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMphonecall> processstagePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMphonetocaseprocess> processstagePhonetocaseprocess = default(IList<MicrosoftDynamicsCRMphonetocaseprocess>), IList<MicrosoftDynamicsCRMproductpricelevel> processstageProductpricelevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMproduct> processstageProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMquote> processstageQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> processstageRecurringappointmentmasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsalesliterature> processstageSalesliteratures = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMsalesorder> processstageSalesorders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMsystemuser> processstageSystemusers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMtask> processstageTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMteam> processstageTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMtranslationprocess> processstageTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), string processstageid = default(string), int? stagecategory = default(int?), string stagename = default(string), object versionnumber = default(object))
        {
            ProcessStageSyncErrors = processStageSyncErrors;
            this._owneridValue = _owneridValue;
            this._processidValue = _processidValue;
            Clientdata = clientdata;
            LkAdoxioApplicationbpfActivestageid = lkAdoxioApplicationbpfActivestageid;
            LkAdoxioApplicationbpfmvpv2Activestageid = lkAdoxioApplicationbpfmvpv2Activestageid;
            LkAdoxioComplaintpublicbpfActivestageid = lkAdoxioComplaintpublicbpfActivestageid;
            LkNewBpf839d33d7035a4f2bbe2150f27b500af6Activestageid = lkNewBpf839d33d7035a4f2bbe2150f27b500af6Activestageid;
            LkNewBpfA5f48dac03e04d1498b374c0638698a2Activestageid = lkNewBpfA5f48dac03e04d1498b374c0638698a2Activestageid;
            Owningbusinessunit = owningbusinessunit;
            Primaryentitytypecode = primaryentitytypecode;
            Processid = processid;
            ProcessstageAccount = processstageAccount;
            ProcessstageAdoxioApplication = processstageAdoxioApplication;
            ProcessstageAdoxioComplaint = processstageAdoxioComplaint;
            ProcessstageAppointments = processstageAppointments;
            ProcessstageCampaignactivities = processstageCampaignactivities;
            ProcessstageCampaignresponses = processstageCampaignresponses;
            ProcessstageCampaigns = processstageCampaigns;
            ProcessstageCompetitors = processstageCompetitors;
            ProcessstageContact = processstageContact;
            ProcessstageEmails = processstageEmails;
            ProcessstageExpiredprocess = processstageExpiredprocess;
            ProcessstageFaxes = processstageFaxes;
            ProcessstageIncident = processstageIncident;
            ProcessstageInvoices = processstageInvoices;
            ProcessstageKnowledgearticle = processstageKnowledgearticle;
            ProcessstageLead = processstageLead;
            ProcessstageLeadtoopportunitysalesprocess = processstageLeadtoopportunitysalesprocess;
            ProcessstageLetters = processstageLetters;
            ProcessstageLists = processstageLists;
            ProcessstageNewprocess = processstageNewprocess;
            ProcessstageOpportunity = processstageOpportunity;
            ProcessstageOpportunitysalesprocess = processstageOpportunitysalesprocess;
            ProcessstagePhonecalls = processstagePhonecalls;
            ProcessstagePhonetocaseprocess = processstagePhonetocaseprocess;
            ProcessstageProductpricelevels = processstageProductpricelevels;
            ProcessstageProducts = processstageProducts;
            ProcessstageQuotes = processstageQuotes;
            ProcessstageRecurringappointmentmasters = processstageRecurringappointmentmasters;
            ProcessstageSalesliteratures = processstageSalesliteratures;
            ProcessstageSalesorders = processstageSalesorders;
            ProcessstageSystemusers = processstageSystemusers;
            ProcessstageTasks = processstageTasks;
            ProcessstageTeams = processstageTeams;
            ProcessstageTranslationprocess = processstageTranslationprocess;
            Processstageid = processstageid;
            Stagecategory = stagecategory;
            Stagename = stagename;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProcessStage_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProcessStageSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_applicationbpf_activestageid")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationbpf> LkAdoxioApplicationbpfActivestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_applicationbpfmvpv2_activestageid")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationbpfmvpv2> LkAdoxioApplicationbpfmvpv2Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_adoxio_complaintpublicbpf_activestageid")]
        public IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> LkAdoxioComplaintpublicbpfActivestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_839d33d7035a4f2bbe2150f27b500af6_activestageid")]
        public IList<MicrosoftDynamicsCRMnewBpf839d33d7035a4f2bbe2150f27b500af6> LkNewBpf839d33d7035a4f2bbe2150f27b500af6Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_a5f48dac03e04d1498b374c0638698a2_activestageid")]
        public IList<MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2> LkNewBpfA5f48dac03e04d1498b374c0638698a2Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_account")]
        public IList<MicrosoftDynamicsCRMaccount> ProcessstageAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_adoxio_application")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> ProcessstageAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_adoxio_complaint")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> ProcessstageAdoxioComplaint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_appointments")]
        public IList<MicrosoftDynamicsCRMappointment> ProcessstageAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignactivities")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> ProcessstageCampaignactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignresponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> ProcessstageCampaignresponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaigns")]
        public IList<MicrosoftDynamicsCRMcampaign> ProcessstageCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_competitors")]
        public IList<MicrosoftDynamicsCRMcompetitor> ProcessstageCompetitors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_contact")]
        public IList<MicrosoftDynamicsCRMcontact> ProcessstageContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_emails")]
        public IList<MicrosoftDynamicsCRMemail> ProcessstageEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_expiredprocess")]
        public IList<MicrosoftDynamicsCRMexpiredprocess> ProcessstageExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_faxes")]
        public IList<MicrosoftDynamicsCRMfax> ProcessstageFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_incident")]
        public IList<MicrosoftDynamicsCRMincident> ProcessstageIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> ProcessstageInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> ProcessstageKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lead")]
        public IList<MicrosoftDynamicsCRMlead> ProcessstageLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> ProcessstageLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_letters")]
        public IList<MicrosoftDynamicsCRMletter> ProcessstageLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lists")]
        public IList<MicrosoftDynamicsCRMlist> ProcessstageLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_newprocess")]
        public IList<MicrosoftDynamicsCRMnewprocess> ProcessstageNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> ProcessstageOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> ProcessstageOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> ProcessstagePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonetocaseprocess")]
        public IList<MicrosoftDynamicsCRMphonetocaseprocess> ProcessstagePhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_productpricelevels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> ProcessstageProductpricelevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_products")]
        public IList<MicrosoftDynamicsCRMproduct> ProcessstageProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_quotes")]
        public IList<MicrosoftDynamicsCRMquote> ProcessstageQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_recurringappointmentmasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ProcessstageRecurringappointmentmasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesliteratures")]
        public IList<MicrosoftDynamicsCRMsalesliterature> ProcessstageSalesliteratures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesorders")]
        public IList<MicrosoftDynamicsCRMsalesorder> ProcessstageSalesorders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_systemusers")]
        public IList<MicrosoftDynamicsCRMsystemuser> ProcessstageSystemusers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_tasks")]
        public IList<MicrosoftDynamicsCRMtask> ProcessstageTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_teams")]
        public IList<MicrosoftDynamicsCRMteam> ProcessstageTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_translationprocess")]
        public IList<MicrosoftDynamicsCRMtranslationprocess> ProcessstageTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstageid")]
        public string Processstageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagecategory")]
        public int? Stagecategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
