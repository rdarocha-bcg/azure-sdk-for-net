// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the policy to be used for placement of a Service Fabric service. </summary>
    public abstract partial class ServicePlacementPolicyDescription
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

        /// <summary> Initializes a new instance of <see cref="ServicePlacementPolicyDescription"/>. </summary>
        protected ServicePlacementPolicyDescription()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServicePlacementPolicyDescription"/>. </summary>
        /// <param name="policyType"> The type of placement policy for a service fabric service. Following are the possible values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePlacementPolicyDescription(ServicePlacementPolicyType policyType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyType = policyType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of placement policy for a service fabric service. Following are the possible values. </summary>
        internal ServicePlacementPolicyType PolicyType { get; set; }
    }
}
