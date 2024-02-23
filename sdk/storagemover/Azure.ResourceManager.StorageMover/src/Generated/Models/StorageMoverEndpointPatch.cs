// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The Endpoint resource. </summary>
    public partial class StorageMoverEndpointPatch
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

        /// <summary> Initializes a new instance of <see cref="StorageMoverEndpointPatch"/>. </summary>
        public StorageMoverEndpointPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageMoverEndpointPatch"/>. </summary>
        /// <param name="properties">
        /// The Endpoint resource, which contains information about file sources and targets.
        /// Please note <see cref="EndpointBaseUpdateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointUpdateProperties"/>, <see cref="AzureStorageSmbFileShareEndpointUpdateProperties"/>, <see cref="NfsMountEndpointUpdateProperties"/> and <see cref="SmbMountEndpointUpdateProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageMoverEndpointPatch(EndpointBaseUpdateProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The Endpoint resource, which contains information about file sources and targets.
        /// Please note <see cref="EndpointBaseUpdateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointUpdateProperties"/>, <see cref="AzureStorageSmbFileShareEndpointUpdateProperties"/>, <see cref="NfsMountEndpointUpdateProperties"/> and <see cref="SmbMountEndpointUpdateProperties"/>.
        /// </summary>
        public EndpointBaseUpdateProperties Properties { get; set; }
    }
}
