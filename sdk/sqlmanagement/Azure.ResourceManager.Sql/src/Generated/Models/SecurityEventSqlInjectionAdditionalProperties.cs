// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The properties of a security event sql injection additional properties. </summary>
    public partial class SecurityEventSqlInjectionAdditionalProperties
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

        /// <summary> Initializes a new instance of <see cref="SecurityEventSqlInjectionAdditionalProperties"/>. </summary>
        internal SecurityEventSqlInjectionAdditionalProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityEventSqlInjectionAdditionalProperties"/>. </summary>
        /// <param name="threatId"> The threat ID. </param>
        /// <param name="statement"> The statement. </param>
        /// <param name="statementHighlightOffset"> The statement highlight offset. </param>
        /// <param name="statementHighlightLength"> The statement highlight length. </param>
        /// <param name="errorCode"> The sql error code. </param>
        /// <param name="errorSeverity"> The sql error severity. </param>
        /// <param name="errorMessage"> The sql error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityEventSqlInjectionAdditionalProperties(string threatId, string statement, int? statementHighlightOffset, int? statementHighlightLength, int? errorCode, int? errorSeverity, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ThreatId = threatId;
            Statement = statement;
            StatementHighlightOffset = statementHighlightOffset;
            StatementHighlightLength = statementHighlightLength;
            ErrorCode = errorCode;
            ErrorSeverity = errorSeverity;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The threat ID. </summary>
        public string ThreatId { get; }
        /// <summary> The statement. </summary>
        public string Statement { get; }
        /// <summary> The statement highlight offset. </summary>
        public int? StatementHighlightOffset { get; }
        /// <summary> The statement highlight length. </summary>
        public int? StatementHighlightLength { get; }
        /// <summary> The sql error code. </summary>
        public int? ErrorCode { get; }
        /// <summary> The sql error severity. </summary>
        public int? ErrorSeverity { get; }
        /// <summary> The sql error message. </summary>
        public string ErrorMessage { get; }
    }
}
