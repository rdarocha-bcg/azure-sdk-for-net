// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
    public partial class FirewallPolicyThreatIntelWhitelist
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

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyThreatIntelWhitelist"/>. </summary>
        public FirewallPolicyThreatIntelWhitelist()
        {
            IPAddresses = new ChangeTrackingList<string>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyThreatIntelWhitelist"/>. </summary>
        /// <param name="ipAddresses"> List of IP addresses for the ThreatIntel Whitelist. </param>
        /// <param name="fqdns"> List of FQDNs for the ThreatIntel Whitelist. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyThreatIntelWhitelist(IList<string> ipAddresses, IList<string> fqdns, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddresses = ipAddresses;
            Fqdns = fqdns;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of IP addresses for the ThreatIntel Whitelist. </summary>
        public IList<string> IPAddresses { get; }
        /// <summary> List of FQDNs for the ThreatIntel Whitelist. </summary>
        public IList<string> Fqdns { get; }
    }
}
