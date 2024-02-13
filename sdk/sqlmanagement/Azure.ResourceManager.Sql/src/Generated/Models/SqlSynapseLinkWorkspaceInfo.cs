// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a Synapse link workspaces. </summary>
    public partial class SqlSynapseLinkWorkspaceInfo
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

        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspaceInfo"/>. </summary>
        public SqlSynapseLinkWorkspaceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspaceInfo"/>. </summary>
        /// <param name="workspaceId"> Synapse link workspace id. </param>
        /// <param name="linkConnectionName"> Link connection name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlSynapseLinkWorkspaceInfo(ResourceIdentifier workspaceId, string linkConnectionName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WorkspaceId = workspaceId;
            LinkConnectionName = linkConnectionName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Synapse link workspace id. </summary>
        public ResourceIdentifier WorkspaceId { get; set; }
        /// <summary> Link connection name. </summary>
        public string LinkConnectionName { get; set; }
    }
}
