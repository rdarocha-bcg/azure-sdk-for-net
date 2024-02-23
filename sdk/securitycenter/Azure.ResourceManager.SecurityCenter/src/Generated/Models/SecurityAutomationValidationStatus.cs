// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The security automation model state property bag. </summary>
    public partial class SecurityAutomationValidationStatus
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

        /// <summary> Initializes a new instance of <see cref="SecurityAutomationValidationStatus"/>. </summary>
        internal SecurityAutomationValidationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAutomationValidationStatus"/>. </summary>
        /// <param name="isValid"> Indicates whether the model is valid or not. </param>
        /// <param name="message"> The validation message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAutomationValidationStatus(bool? isValid, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsValid = isValid;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the model is valid or not. </summary>
        public bool? IsValid { get; }
        /// <summary> The validation message. </summary>
        public string Message { get; }
    }
}
