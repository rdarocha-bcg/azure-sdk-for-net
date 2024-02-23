// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic list. </summary>
    public partial class SwaggerCustomDynamicList
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

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicList"/>. </summary>
        public SwaggerCustomDynamicList()
        {
            Parameters = new ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicList"/>. </summary>
        /// <param name="operationId"> The operation id to fetch dynamic schema. </param>
        /// <param name="builtInOperation"> The built in operation. </param>
        /// <param name="itemsPath"> The path to a response property (relative to the response object, not the response body) which contains an array of dynamic value items. </param>
        /// <param name="itemValuePath"> The path to a property which defines the value which should be used. </param>
        /// <param name="itemTitlePath"> The path to an item property which defines the display name of the item. </param>
        /// <param name="parameters"> The parameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwaggerCustomDynamicList(string operationId, string builtInOperation, string itemsPath, string itemValuePath, string itemTitlePath, IDictionary<string, SwaggerCustomDynamicProperties> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationId = operationId;
            BuiltInOperation = builtInOperation;
            ItemsPath = itemsPath;
            ItemValuePath = itemValuePath;
            ItemTitlePath = itemTitlePath;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The operation id to fetch dynamic schema. </summary>
        public string OperationId { get; set; }
        /// <summary> The built in operation. </summary>
        public string BuiltInOperation { get; set; }
        /// <summary> The path to a response property (relative to the response object, not the response body) which contains an array of dynamic value items. </summary>
        public string ItemsPath { get; set; }
        /// <summary> The path to a property which defines the value which should be used. </summary>
        public string ItemValuePath { get; set; }
        /// <summary> The path to an item property which defines the display name of the item. </summary>
        public string ItemTitlePath { get; set; }
        /// <summary> The parameters. </summary>
        public IDictionary<string, SwaggerCustomDynamicProperties> Parameters { get; }
    }
}
