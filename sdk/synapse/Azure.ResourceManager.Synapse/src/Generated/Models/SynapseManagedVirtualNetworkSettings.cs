// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Managed Virtual Network Settings. </summary>
    public partial class SynapseManagedVirtualNetworkSettings
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

        /// <summary> Initializes a new instance of <see cref="SynapseManagedVirtualNetworkSettings"/>. </summary>
        public SynapseManagedVirtualNetworkSettings()
        {
            AllowedAadTenantIdsForLinking = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseManagedVirtualNetworkSettings"/>. </summary>
        /// <param name="preventDataExfiltration"> Prevent Data Exfiltration. </param>
        /// <param name="enableLinkedAccessCheckOnTargetResource"> Linked Access Check On Target Resource. </param>
        /// <param name="allowedAadTenantIdsForLinking"> Allowed Aad Tenant Ids For Linking. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseManagedVirtualNetworkSettings(bool? preventDataExfiltration, bool? enableLinkedAccessCheckOnTargetResource, IList<string> allowedAadTenantIdsForLinking, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PreventDataExfiltration = preventDataExfiltration;
            EnableLinkedAccessCheckOnTargetResource = enableLinkedAccessCheckOnTargetResource;
            AllowedAadTenantIdsForLinking = allowedAadTenantIdsForLinking;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Prevent Data Exfiltration. </summary>
        public bool? PreventDataExfiltration { get; set; }
        /// <summary> Linked Access Check On Target Resource. </summary>
        public bool? EnableLinkedAccessCheckOnTargetResource { get; set; }
        /// <summary> Allowed Aad Tenant Ids For Linking. </summary>
        public IList<string> AllowedAadTenantIdsForLinking { get; }
    }
}
