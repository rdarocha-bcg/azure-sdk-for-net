// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A voice receiver. </summary>
    public partial class MonitorVoiceReceiver
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

        /// <summary> Initializes a new instance of <see cref="MonitorVoiceReceiver"/>. </summary>
        /// <param name="name"> The name of the voice receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="countryCode"> The country code of the voice receiver. </param>
        /// <param name="phoneNumber"> The phone number of the voice receiver. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="countryCode"/> or <paramref name="phoneNumber"/> is null. </exception>
        public MonitorVoiceReceiver(string name, string countryCode, string phoneNumber)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(countryCode, nameof(countryCode));
            Argument.AssertNotNull(phoneNumber, nameof(phoneNumber));

            Name = name;
            CountryCode = countryCode;
            PhoneNumber = phoneNumber;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorVoiceReceiver"/>. </summary>
        /// <param name="name"> The name of the voice receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="countryCode"> The country code of the voice receiver. </param>
        /// <param name="phoneNumber"> The phone number of the voice receiver. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorVoiceReceiver(string name, string countryCode, string phoneNumber, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            CountryCode = countryCode;
            PhoneNumber = phoneNumber;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorVoiceReceiver"/> for deserialization. </summary>
        internal MonitorVoiceReceiver()
        {
        }

        /// <summary> The name of the voice receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The country code of the voice receiver. </summary>
        public string CountryCode { get; set; }
        /// <summary> The phone number of the voice receiver. </summary>
        public string PhoneNumber { get; set; }
    }
}
