// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> TrunkedNetworkAttachmentConfiguration represents the configuration of the attachment of a trunked network. </summary>
    public partial class TrunkedNetworkAttachmentConfiguration
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

        /// <summary> Initializes a new instance of <see cref="TrunkedNetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkId"/> is null. </exception>
        public TrunkedNetworkAttachmentConfiguration(ResourceIdentifier networkId)
        {
            if (networkId == null)
            {
                throw new ArgumentNullException(nameof(networkId));
            }

            NetworkId = networkId;
        }

        /// <summary> Initializes a new instance of <see cref="TrunkedNetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <param name="pluginType"> The indicator of how this network will be utilized by the Kubernetes cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrunkedNetworkAttachmentConfiguration(ResourceIdentifier networkId, KubernetesPluginType? pluginType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkId = networkId;
            PluginType = pluginType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrunkedNetworkAttachmentConfiguration"/> for deserialization. </summary>
        internal TrunkedNetworkAttachmentConfiguration()
        {
        }

        /// <summary> The resource ID of the network that is being configured for attachment. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary> The indicator of how this network will be utilized by the Kubernetes cluster. </summary>
        public KubernetesPluginType? PluginType { get; set; }
    }
}
