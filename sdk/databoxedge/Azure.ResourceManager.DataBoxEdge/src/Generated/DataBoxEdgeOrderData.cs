// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeOrder data model.
    /// The order details.
    /// </summary>
    public partial class DataBoxEdgeOrderData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeOrderData"/>. </summary>
        public DataBoxEdgeOrderData()
        {
            OrderHistory = new ChangeTrackingList<DataBoxEdgeOrderStatus>();
            DeliveryTrackingInfo = new ChangeTrackingList<DataBoxEdgeTrackingInfo>();
            ReturnTrackingInfo = new ChangeTrackingList<DataBoxEdgeTrackingInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeOrderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> It specify the order api version. </param>
        /// <param name="orderId"> It specify the order resource id. </param>
        /// <param name="contactInformation"> The contact details. </param>
        /// <param name="shippingAddress"> The shipping address. </param>
        /// <param name="currentStatus"> Current status of the order. </param>
        /// <param name="orderHistory"> List of status changes in the order. </param>
        /// <param name="serialNumber"> Serial number of the device. </param>
        /// <param name="deliveryTrackingInfo"> Tracking information for the package delivered to the customer whether it has an original or a replacement device. </param>
        /// <param name="returnTrackingInfo"> Tracking information for the package returned from the customer whether it has an original or a replacement device. </param>
        /// <param name="shipmentType"> ShipmentType of the order. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeOrderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string orderId, DataBoxEdgeContactDetails contactInformation, DataBoxEdgeShippingAddress shippingAddress, DataBoxEdgeOrderStatus currentStatus, IReadOnlyList<DataBoxEdgeOrderStatus> orderHistory, string serialNumber, IReadOnlyList<DataBoxEdgeTrackingInfo> deliveryTrackingInfo, IReadOnlyList<DataBoxEdgeTrackingInfo> returnTrackingInfo, DataBoxEdgeShipmentType? shipmentType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            OrderId = orderId;
            ContactInformation = contactInformation;
            ShippingAddress = shippingAddress;
            CurrentStatus = currentStatus;
            OrderHistory = orderHistory;
            SerialNumber = serialNumber;
            DeliveryTrackingInfo = deliveryTrackingInfo;
            ReturnTrackingInfo = returnTrackingInfo;
            ShipmentType = shipmentType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> It specify the order api version. </summary>
        public string Kind { get; }
        /// <summary> It specify the order resource id. </summary>
        public string OrderId { get; }
        /// <summary> The contact details. </summary>
        public DataBoxEdgeContactDetails ContactInformation { get; set; }
        /// <summary> The shipping address. </summary>
        public DataBoxEdgeShippingAddress ShippingAddress { get; set; }
        /// <summary> Current status of the order. </summary>
        public DataBoxEdgeOrderStatus CurrentStatus { get; }
        /// <summary> List of status changes in the order. </summary>
        public IReadOnlyList<DataBoxEdgeOrderStatus> OrderHistory { get; }
        /// <summary> Serial number of the device. </summary>
        public string SerialNumber { get; }
        /// <summary> Tracking information for the package delivered to the customer whether it has an original or a replacement device. </summary>
        public IReadOnlyList<DataBoxEdgeTrackingInfo> DeliveryTrackingInfo { get; }
        /// <summary> Tracking information for the package returned from the customer whether it has an original or a replacement device. </summary>
        public IReadOnlyList<DataBoxEdgeTrackingInfo> ReturnTrackingInfo { get; }
        /// <summary> ShipmentType of the order. </summary>
        public DataBoxEdgeShipmentType? ShipmentType { get; set; }
    }
}
