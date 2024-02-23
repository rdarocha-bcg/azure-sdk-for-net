// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains the DDoS protection settings of the public IP. </summary>
    public partial class DdosSettings
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

        /// <summary> Initializes a new instance of <see cref="DdosSettings"/>. </summary>
        public DdosSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DdosSettings"/>. </summary>
        /// <param name="protectionMode"> The DDoS protection mode of the public IP. </param>
        /// <param name="ddosProtectionPlan"> The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DdosSettings(DdosSettingsProtectionMode? protectionMode, WritableSubResource ddosProtectionPlan, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtectionMode = protectionMode;
            DdosProtectionPlan = ddosProtectionPlan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The DDoS protection mode of the public IP. </summary>
        public DdosSettingsProtectionMode? ProtectionMode { get; set; }
        /// <summary> The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled. </summary>
        internal WritableSubResource DdosProtectionPlan { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DdosProtectionPlanId
        {
            get => DdosProtectionPlan is null ? default : DdosProtectionPlan.Id;
            set
            {
                if (DdosProtectionPlan is null)
                    DdosProtectionPlan = new WritableSubResource();
                DdosProtectionPlan.Id = value;
            }
        }
    }
}
