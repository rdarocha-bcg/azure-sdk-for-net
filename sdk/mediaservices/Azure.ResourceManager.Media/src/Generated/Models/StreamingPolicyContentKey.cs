// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify properties of content key. </summary>
    public partial class StreamingPolicyContentKey
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

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKey"/>. </summary>
        public StreamingPolicyContentKey()
        {
            Tracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKey"/>. </summary>
        /// <param name="label"> Label can be used to specify Content Key when creating a Streaming Locator. </param>
        /// <param name="policyName"> Policy used by Content Key. </param>
        /// <param name="tracks"> Tracks which use this content key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingPolicyContentKey(string label, string policyName, IList<MediaTrackSelection> tracks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Label = label;
            PolicyName = policyName;
            Tracks = tracks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Label can be used to specify Content Key when creating a Streaming Locator. </summary>
        public string Label { get; set; }
        /// <summary> Policy used by Content Key. </summary>
        public string PolicyName { get; set; }
        /// <summary> Tracks which use this content key. </summary>
        public IList<MediaTrackSelection> Tracks { get; }
    }
}
