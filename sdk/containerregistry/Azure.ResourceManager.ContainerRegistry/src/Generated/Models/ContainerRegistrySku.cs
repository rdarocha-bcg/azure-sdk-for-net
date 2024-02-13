// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The SKU of a container registry. </summary>
    public partial class ContainerRegistrySku
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySku"/>. </summary>
        /// <param name="name"> The SKU name of the container registry. Required for registry creation. </param>
        public ContainerRegistrySku(ContainerRegistrySkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySku"/>. </summary>
        /// <param name="name"> The SKU name of the container registry. Required for registry creation. </param>
        /// <param name="tier"> The SKU tier based on the SKU name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistrySku(ContainerRegistrySkuName name, ContainerRegistrySkuTier? tier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySku"/> for deserialization. </summary>
        internal ContainerRegistrySku()
        {
        }

        /// <summary> The SKU name of the container registry. Required for registry creation. </summary>
        public ContainerRegistrySkuName Name { get; set; }
        /// <summary> The SKU tier based on the SKU name. </summary>
        public ContainerRegistrySkuTier? Tier { get; }
    }
}
