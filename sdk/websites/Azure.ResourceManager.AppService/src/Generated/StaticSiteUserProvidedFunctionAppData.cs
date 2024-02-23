// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the StaticSiteUserProvidedFunctionApp data model.
    /// Static Site User Provided Function App ARM resource.
    /// </summary>
    public partial class StaticSiteUserProvidedFunctionAppData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="StaticSiteUserProvidedFunctionAppData"/>. </summary>
        public StaticSiteUserProvidedFunctionAppData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteUserProvidedFunctionAppData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionAppResourceId"> The resource id of the function app registered with the static site. </param>
        /// <param name="functionAppRegion"> The region of the function app registered with the static site. </param>
        /// <param name="createdOn"> The date and time on which the function app was registered with the static site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteUserProvidedFunctionAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier functionAppResourceId, string functionAppRegion, DateTimeOffset? createdOn, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            FunctionAppResourceId = functionAppResourceId;
            FunctionAppRegion = functionAppRegion;
            CreatedOn = createdOn;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource id of the function app registered with the static site. </summary>
        public ResourceIdentifier FunctionAppResourceId { get; set; }
        /// <summary> The region of the function app registered with the static site. </summary>
        public string FunctionAppRegion { get; set; }
        /// <summary> The date and time on which the function app was registered with the static site. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
