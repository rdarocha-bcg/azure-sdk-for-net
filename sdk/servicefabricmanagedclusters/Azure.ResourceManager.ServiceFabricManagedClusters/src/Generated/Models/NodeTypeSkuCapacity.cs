// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Provides information about how node type can be scaled. </summary>
    public partial class NodeTypeSkuCapacity
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

        /// <summary> Initializes a new instance of <see cref="NodeTypeSkuCapacity"/>. </summary>
        internal NodeTypeSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeSkuCapacity"/>. </summary>
        /// <param name="minimum"> Lowest permitted node count in a node type. </param>
        /// <param name="maximum"> Highest permitted node count in a node type. </param>
        /// <param name="default"> Default node count in a node type. </param>
        /// <param name="scaleType"> Node type capacity scale type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NodeTypeSkuCapacity(int? minimum, int? maximum, int? @default, NodeTypeSkuScaleType? scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Lowest permitted node count in a node type. </summary>
        public int? Minimum { get; }
        /// <summary> Highest permitted node count in a node type. </summary>
        public int? Maximum { get; }
        /// <summary> Default node count in a node type. </summary>
        public int? Default { get; }
        /// <summary> Node type capacity scale type. </summary>
        public NodeTypeSkuScaleType? ScaleType { get; }
    }
}
