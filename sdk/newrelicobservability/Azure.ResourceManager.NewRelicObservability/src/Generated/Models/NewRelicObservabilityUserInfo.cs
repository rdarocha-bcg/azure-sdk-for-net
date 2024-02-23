// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> User Info of NewRelic Monitor resource. </summary>
    public partial class NewRelicObservabilityUserInfo
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

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityUserInfo"/>. </summary>
        public NewRelicObservabilityUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityUserInfo"/>. </summary>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="emailAddress"> User Email. </param>
        /// <param name="phoneNumber"> Contact phone number. </param>
        /// <param name="country"> country if user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityUserInfo(string firstName, string lastName, string emailAddress, string phoneNumber, string country, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Country = country;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
        /// <summary> User Email. </summary>
        public string EmailAddress { get; set; }
        /// <summary> Contact phone number. </summary>
        public string PhoneNumber { get; set; }
        /// <summary> country if user. </summary>
        public string Country { get; set; }
    }
}
