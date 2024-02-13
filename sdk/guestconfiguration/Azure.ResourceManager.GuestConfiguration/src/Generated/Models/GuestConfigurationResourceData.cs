// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> The core properties of guest configuration resources. </summary>
    public partial class GuestConfigurationResourceData
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationResourceData"/>. </summary>
        public GuestConfigurationResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationResourceData"/>. </summary>
        /// <param name="id"> ARM resource id of the guest configuration assignment. </param>
        /// <param name="name"> Name of the guest configuration assignment. </param>
        /// <param name="location"> Region where the VM is located. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationResourceData(ResourceIdentifier id, string name, AzureLocation? location, ResourceType? resourceType, SystemData systemData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Location = location;
            ResourceType = resourceType;
            SystemData = systemData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ARM resource id of the guest configuration assignment. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Name of the guest configuration assignment. </summary>
        public string Name { get; set; }
        /// <summary> Region where the VM is located. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The type of the resource. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Azure Resource Manager metadata containing createdBy and modifiedBy information. </summary>
        public SystemData SystemData { get; }
    }
}
