// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> reservation summary resource. </summary>
    public partial class ConsumptionReservationSummary : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionReservationSummary"/>. </summary>
        internal ConsumptionReservationSummary()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionReservationSummary"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="reservationOrderId"> The reservation order ID is the identifier for a reservation purchase. Each reservation order ID represents a single purchase transaction. A reservation order contains reservations. The reservation order specifies the VM size and region for the reservations. </param>
        /// <param name="reservationId"> The reservation ID is the identifier of a reservation within a reservation order. Each reservation is the grouping for applying the benefit scope and also specifies the number of instances to which the reservation benefit can be applied to. </param>
        /// <param name="skuName"> This is the ARM Sku name. It can be used to join with the serviceType field in additional info in usage records. </param>
        /// <param name="reservedHours"> This is the total hours reserved. E.g. if reservation for 1 instance was made on 1 PM, this will be 11 hours for that day and 24 hours from subsequent days. </param>
        /// <param name="useOn"> Data corresponding to the utilization record. If the grain of data is monthly, it will be first day of month. </param>
        /// <param name="usedHours"> Total used hours by the reservation. </param>
        /// <param name="minUtilizationPercentage"> This is the minimum hourly utilization in the usage time (day or month). E.g. if usage record corresponds to 12/10/2017 and on that for hour 4 and 5, utilization was 10%, this field will return 10% for that day. </param>
        /// <param name="avgUtilizationPercentage"> This is average utilization for the entire time range. (day or month depending on the grain). </param>
        /// <param name="maxUtilizationPercentage"> This is the maximum hourly utilization in the usage time (day or month). E.g. if usage record corresponds to 12/10/2017 and on that for hour 4 and 5, utilization was 100%, this field will return 100% for that day. </param>
        /// <param name="kind"> The reservation kind. </param>
        /// <param name="purchasedQuantity"> This is the purchased quantity for the reservationId. </param>
        /// <param name="remainingQuantity"> This is the remaining quantity for the reservationId. </param>
        /// <param name="totalReservedQuantity"> This is the total count of instances that are reserved for the reservationId. </param>
        /// <param name="usedQuantity"> This is the used quantity for the reservationId. </param>
        /// <param name="utilizedPercentage"> This is the utilized percentage for the reservation Id. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionReservationSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string reservationOrderId, string reservationId, string skuName, decimal? reservedHours, DateTimeOffset? useOn, decimal? usedHours, decimal? minUtilizationPercentage, decimal? avgUtilizationPercentage, decimal? maxUtilizationPercentage, string kind, decimal? purchasedQuantity, decimal? remainingQuantity, decimal? totalReservedQuantity, decimal? usedQuantity, decimal? utilizedPercentage, ETag? etag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ReservationOrderId = reservationOrderId;
            ReservationId = reservationId;
            SkuName = skuName;
            ReservedHours = reservedHours;
            UseOn = useOn;
            UsedHours = usedHours;
            MinUtilizationPercentage = minUtilizationPercentage;
            AvgUtilizationPercentage = avgUtilizationPercentage;
            MaxUtilizationPercentage = maxUtilizationPercentage;
            Kind = kind;
            PurchasedQuantity = purchasedQuantity;
            RemainingQuantity = remainingQuantity;
            TotalReservedQuantity = totalReservedQuantity;
            UsedQuantity = usedQuantity;
            UtilizedPercentage = utilizedPercentage;
            ETag = etag;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The reservation order ID is the identifier for a reservation purchase. Each reservation order ID represents a single purchase transaction. A reservation order contains reservations. The reservation order specifies the VM size and region for the reservations. </summary>
        public string ReservationOrderId { get; }
        /// <summary> The reservation ID is the identifier of a reservation within a reservation order. Each reservation is the grouping for applying the benefit scope and also specifies the number of instances to which the reservation benefit can be applied to. </summary>
        public string ReservationId { get; }
        /// <summary> This is the ARM Sku name. It can be used to join with the serviceType field in additional info in usage records. </summary>
        public string SkuName { get; }
        /// <summary> This is the total hours reserved. E.g. if reservation for 1 instance was made on 1 PM, this will be 11 hours for that day and 24 hours from subsequent days. </summary>
        public decimal? ReservedHours { get; }
        /// <summary> Data corresponding to the utilization record. If the grain of data is monthly, it will be first day of month. </summary>
        public DateTimeOffset? UseOn { get; }
        /// <summary> Total used hours by the reservation. </summary>
        public decimal? UsedHours { get; }
        /// <summary> This is the minimum hourly utilization in the usage time (day or month). E.g. if usage record corresponds to 12/10/2017 and on that for hour 4 and 5, utilization was 10%, this field will return 10% for that day. </summary>
        public decimal? MinUtilizationPercentage { get; }
        /// <summary> This is average utilization for the entire time range. (day or month depending on the grain). </summary>
        public decimal? AvgUtilizationPercentage { get; }
        /// <summary> This is the maximum hourly utilization in the usage time (day or month). E.g. if usage record corresponds to 12/10/2017 and on that for hour 4 and 5, utilization was 100%, this field will return 100% for that day. </summary>
        public decimal? MaxUtilizationPercentage { get; }
        /// <summary> The reservation kind. </summary>
        public string Kind { get; }
        /// <summary> This is the purchased quantity for the reservationId. </summary>
        public decimal? PurchasedQuantity { get; }
        /// <summary> This is the remaining quantity for the reservationId. </summary>
        public decimal? RemainingQuantity { get; }
        /// <summary> This is the total count of instances that are reserved for the reservationId. </summary>
        public decimal? TotalReservedQuantity { get; }
        /// <summary> This is the used quantity for the reservationId. </summary>
        public decimal? UsedQuantity { get; }
        /// <summary> This is the utilized percentage for the reservation Id. </summary>
        public decimal? UtilizedPercentage { get; }
        /// <summary> The etag for the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
