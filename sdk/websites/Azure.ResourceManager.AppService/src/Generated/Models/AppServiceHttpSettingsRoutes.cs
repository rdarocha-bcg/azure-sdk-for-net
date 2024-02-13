// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the paths HTTP requests. </summary>
    internal partial class AppServiceHttpSettingsRoutes
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

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettingsRoutes"/>. </summary>
        public AppServiceHttpSettingsRoutes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettingsRoutes"/>. </summary>
        /// <param name="apiPrefix"> The prefix that should precede all the authentication/authorization paths. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceHttpSettingsRoutes(string apiPrefix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiPrefix = apiPrefix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The prefix that should precede all the authentication/authorization paths. </summary>
        public string ApiPrefix { get; set; }
    }
}
