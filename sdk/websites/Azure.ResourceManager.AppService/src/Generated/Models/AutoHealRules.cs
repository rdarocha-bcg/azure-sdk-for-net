// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Rules that can be defined for auto-heal. </summary>
    public partial class AutoHealRules
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

        /// <summary> Initializes a new instance of <see cref="AutoHealRules"/>. </summary>
        public AutoHealRules()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoHealRules"/>. </summary>
        /// <param name="triggers"> Conditions that describe when to execute the auto-heal actions. </param>
        /// <param name="actions"> Actions to be executed when a rule is triggered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoHealRules(AutoHealTriggers triggers, AutoHealActions actions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Triggers = triggers;
            Actions = actions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Conditions that describe when to execute the auto-heal actions. </summary>
        public AutoHealTriggers Triggers { get; set; }
        /// <summary> Actions to be executed when a rule is triggered. </summary>
        public AutoHealActions Actions { get; set; }
    }
}
