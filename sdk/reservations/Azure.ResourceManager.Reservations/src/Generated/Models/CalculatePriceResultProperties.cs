// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties for calculate price response. </summary>
    public partial class CalculatePriceResultProperties
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

        /// <summary> Initializes a new instance of <see cref="CalculatePriceResultProperties"/>. </summary>
        internal CalculatePriceResultProperties()
        {
            PaymentSchedule = new ChangeTrackingList<PaymentDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="CalculatePriceResultProperties"/>. </summary>
        /// <param name="billingCurrencyTotal"> Currency and amount that customer will be charged in customer's local currency. Tax is not included. </param>
        /// <param name="netTotal"> Net total amount in pricing currency. </param>
        /// <param name="taxTotal"> Tax amount in pricing currency. </param>
        /// <param name="grandTotal"> Total amount in pricing currency. </param>
        /// <param name="isTaxIncluded"> Whether or not tax is included in grand total. </param>
        /// <param name="isBillingPartnerManaged"> True if billing is managed by Microsoft Partner. Used only for CSP accounts. </param>
        /// <param name="reservationOrderId"> GUID that represents reservation order that can be placed after calculating price. </param>
        /// <param name="skuTitle"> Title of sku that is being purchased. </param>
        /// <param name="skuDescription"> Description of sku that is being purchased. </param>
        /// <param name="pricingCurrencyTotal"> Amount that Microsoft uses for record. Used during refund for calculating refund limit. Tax is not included. </param>
        /// <param name="paymentSchedule"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CalculatePriceResultProperties(CalculatePriceResultPropertiesBillingCurrencyTotal billingCurrencyTotal, double? netTotal, double? taxTotal, double? grandTotal, bool? isTaxIncluded, bool? isBillingPartnerManaged, Guid? reservationOrderId, string skuTitle, string skuDescription, CalculatePriceResultPropertiesPricingCurrencyTotal pricingCurrencyTotal, IReadOnlyList<PaymentDetail> paymentSchedule, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BillingCurrencyTotal = billingCurrencyTotal;
            NetTotal = netTotal;
            TaxTotal = taxTotal;
            GrandTotal = grandTotal;
            IsTaxIncluded = isTaxIncluded;
            IsBillingPartnerManaged = isBillingPartnerManaged;
            ReservationOrderId = reservationOrderId;
            SkuTitle = skuTitle;
            SkuDescription = skuDescription;
            PricingCurrencyTotal = pricingCurrencyTotal;
            PaymentSchedule = paymentSchedule;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Currency and amount that customer will be charged in customer's local currency. Tax is not included. </summary>
        public CalculatePriceResultPropertiesBillingCurrencyTotal BillingCurrencyTotal { get; }
        /// <summary> Net total amount in pricing currency. </summary>
        public double? NetTotal { get; }
        /// <summary> Tax amount in pricing currency. </summary>
        public double? TaxTotal { get; }
        /// <summary> Total amount in pricing currency. </summary>
        public double? GrandTotal { get; }
        /// <summary> Whether or not tax is included in grand total. </summary>
        public bool? IsTaxIncluded { get; }
        /// <summary> True if billing is managed by Microsoft Partner. Used only for CSP accounts. </summary>
        public bool? IsBillingPartnerManaged { get; }
        /// <summary> GUID that represents reservation order that can be placed after calculating price. </summary>
        public Guid? ReservationOrderId { get; }
        /// <summary> Title of sku that is being purchased. </summary>
        public string SkuTitle { get; }
        /// <summary> Description of sku that is being purchased. </summary>
        public string SkuDescription { get; }
        /// <summary> Amount that Microsoft uses for record. Used during refund for calculating refund limit. Tax is not included. </summary>
        public CalculatePriceResultPropertiesPricingCurrencyTotal PricingCurrencyTotal { get; }
        /// <summary> Gets the payment schedule. </summary>
        public IReadOnlyList<PaymentDetail> PaymentSchedule { get; }
    }
}
