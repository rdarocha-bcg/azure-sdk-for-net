// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary> A class representing the ManagedServicesMarketplaceRegistration data model. </summary>
    public partial class ManagedServicesMarketplaceRegistrationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ManagedServicesMarketplaceRegistrationData"/>. </summary>
        internal ManagedServicesMarketplaceRegistrationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesMarketplaceRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of the marketplace registration definition. </param>
        /// <param name="plan"> The details for the Managed Services offer’s plan in Azure Marketplace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesMarketplaceRegistrationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServicesMarketplaceRegistrationProperties properties, ManagedServicesPlan plan, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Plan = plan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The properties of the marketplace registration definition. </summary>
        public ManagedServicesMarketplaceRegistrationProperties Properties { get; }
        /// <summary> The details for the Managed Services offer’s plan in Azure Marketplace. </summary>
        public ManagedServicesPlan Plan { get; }
    }
}
