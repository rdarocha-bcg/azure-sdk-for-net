// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Set workload type to optimize storage for SQL Server. </summary>
    internal partial class SqlWorkloadTypeUpdateSettings
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

        /// <summary> Initializes a new instance of <see cref="SqlWorkloadTypeUpdateSettings"/>. </summary>
        public SqlWorkloadTypeUpdateSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlWorkloadTypeUpdateSettings"/>. </summary>
        /// <param name="sqlWorkloadType"> SQL Server workload type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlWorkloadTypeUpdateSettings(SqlWorkloadType? sqlWorkloadType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SqlWorkloadType = sqlWorkloadType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SQL Server workload type. </summary>
        public SqlWorkloadType? SqlWorkloadType { get; set; }
    }
}
