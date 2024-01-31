// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The instance pool capability. </summary>
    public partial class InstancePoolEditionCapability
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

        /// <summary> Initializes a new instance of <see cref="InstancePoolEditionCapability"/>. </summary>
        internal InstancePoolEditionCapability()
        {
            SupportedFamilies = new ChangeTrackingList<InstancePoolFamilyCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="InstancePoolEditionCapability"/>. </summary>
        /// <param name="name"> The instance pool version name. </param>
        /// <param name="supportedFamilies"> The supported families. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstancePoolEditionCapability(string name, IReadOnlyList<InstancePoolFamilyCapability> supportedFamilies, SqlCapabilityStatus? status, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SupportedFamilies = supportedFamilies;
            Status = status;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The instance pool version name. </summary>
        public string Name { get; }
        /// <summary> The supported families. </summary>
        public IReadOnlyList<InstancePoolFamilyCapability> SupportedFamilies { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
