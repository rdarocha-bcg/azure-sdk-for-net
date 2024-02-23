// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A class representing the BillingBenefitsSavingsPlanOrder data model.
    /// Savings plan order
    /// </summary>
    public partial class BillingBenefitsSavingsPlanOrderData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderData"/>. </summary>
        /// <param name="sku"> Savings plan SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public BillingBenefitsSavingsPlanOrderData(BillingBenefitsSku sku)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            SavingsPlans = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Savings plan SKU. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing the benefit. </param>
        /// <param name="billingProfileId"> Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led customers. </param>
        /// <param name="customerId"> Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers. </param>
        /// <param name="billingAccountId"> Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement customers. </param>
        /// <param name="term"> Represent benefit term in ISO 8601 format. </param>
        /// <param name="billingPlan"> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </param>
        /// <param name="expireOn"> Expiry date time. </param>
        /// <param name="benefitStartOn"> This is the DateTime when the savings plan benefit started. </param>
        /// <param name="planInformation"> Information describing the type of billing plan for this savings plan. </param>
        /// <param name="savingsPlans"></param>
        /// <param name="extendedStatusInfo"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsSavingsPlanOrderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingBenefitsSku sku, string displayName, BillingBenefitsProvisioningState? provisioningState, ResourceIdentifier billingScopeId, ResourceIdentifier billingProfileId, string customerId, ResourceIdentifier billingAccountId, BillingBenefitsTerm? term, BillingBenefitsBillingPlan? billingPlan, DateTimeOffset? expireOn, DateTimeOffset? benefitStartOn, BillingPlanInformation planInformation, IList<string> savingsPlans, BillingBenefitsExtendedStatusInfo extendedStatusInfo, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            DisplayName = displayName;
            ProvisioningState = provisioningState;
            BillingScopeId = billingScopeId;
            BillingProfileId = billingProfileId;
            CustomerId = customerId;
            BillingAccountId = billingAccountId;
            Term = term;
            BillingPlan = billingPlan;
            ExpireOn = expireOn;
            BenefitStartOn = benefitStartOn;
            PlanInformation = planInformation;
            SavingsPlans = savingsPlans;
            ExtendedStatusInfo = extendedStatusInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSavingsPlanOrderData"/> for deserialization. </summary>
        internal BillingBenefitsSavingsPlanOrderData()
        {
        }

        /// <summary> Savings plan SKU. </summary>
        internal BillingBenefitsSku Sku { get; set; }
        /// <summary> Name of the SKU to be applied. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingBenefitsSku();
                Sku.Name = value;
            }
        }

        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Provisioning state. </summary>
        public BillingBenefitsProvisioningState? ProvisioningState { get; }
        /// <summary> Subscription that will be charged for purchasing the benefit. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led customers. </summary>
        public ResourceIdentifier BillingProfileId { get; }
        /// <summary> Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers. </summary>
        public string CustomerId { get; }
        /// <summary> Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement customers. </summary>
        public ResourceIdentifier BillingAccountId { get; }
        /// <summary> Represent benefit term in ISO 8601 format. </summary>
        public BillingBenefitsTerm? Term { get; set; }
        /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
        public BillingBenefitsBillingPlan? BillingPlan { get; set; }
        /// <summary> Expiry date time. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> This is the DateTime when the savings plan benefit started. </summary>
        public DateTimeOffset? BenefitStartOn { get; set; }
        /// <summary> Information describing the type of billing plan for this savings plan. </summary>
        public BillingPlanInformation PlanInformation { get; set; }
        /// <summary> Gets the savings plans. </summary>
        public IList<string> SavingsPlans { get; }
        /// <summary> Gets the extended status info. </summary>
        public BillingBenefitsExtendedStatusInfo ExtendedStatusInfo { get; }
    }
}
