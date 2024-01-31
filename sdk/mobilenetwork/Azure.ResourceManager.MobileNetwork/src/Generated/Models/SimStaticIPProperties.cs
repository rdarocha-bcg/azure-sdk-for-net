// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Static IP configuration for a SIM, scoped to a particular attached data network and slice. </summary>
    public partial class SimStaticIPProperties
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

        /// <summary> Initializes a new instance of <see cref="SimStaticIPProperties"/>. </summary>
        public SimStaticIPProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SimStaticIPProperties"/>. </summary>
        /// <param name="attachedDataNetwork"> The attached data network on which the static IP address will be used. The combination of attached data network and slice defines the network scope of the IP address. The attached data network must be in the same location as the SIM. </param>
        /// <param name="slice"> The network slice on which the static IP address will be used. The combination of attached data network and slice defines the network scope of the IP address. The slice must be in the same location as the SIM. </param>
        /// <param name="staticIP"> The static IP configuration for the SIM to use at the defined network scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SimStaticIPProperties(WritableSubResource attachedDataNetwork, WritableSubResource slice, SimStaticIPPropertiesStaticIP staticIP, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AttachedDataNetwork = attachedDataNetwork;
            Slice = slice;
            StaticIP = staticIP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The attached data network on which the static IP address will be used. The combination of attached data network and slice defines the network scope of the IP address. The attached data network must be in the same location as the SIM. </summary>
        internal WritableSubResource AttachedDataNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AttachedDataNetworkId
        {
            get => AttachedDataNetwork is null ? default : AttachedDataNetwork.Id;
            set
            {
                if (AttachedDataNetwork is null)
                    AttachedDataNetwork = new WritableSubResource();
                AttachedDataNetwork.Id = value;
            }
        }

        /// <summary> The network slice on which the static IP address will be used. The combination of attached data network and slice defines the network scope of the IP address. The slice must be in the same location as the SIM. </summary>
        internal WritableSubResource Slice { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SliceId
        {
            get => Slice is null ? default : Slice.Id;
            set
            {
                if (Slice is null)
                    Slice = new WritableSubResource();
                Slice.Id = value;
            }
        }

        /// <summary> The static IP configuration for the SIM to use at the defined network scope. </summary>
        internal SimStaticIPPropertiesStaticIP StaticIP { get; set; }
        /// <summary> The IPv4 address assigned to the SIM at this network scope. This address must be in the userEquipmentStaticAddressPoolPrefix defined in the attached data network. </summary>
        public string StaticIPIPv4Address
        {
            get => StaticIP is null ? default : StaticIP.IPv4Address;
            set
            {
                if (StaticIP is null)
                    StaticIP = new SimStaticIPPropertiesStaticIP();
                StaticIP.IPv4Address = value;
            }
        }
    }
}
