// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LightHouseAuthorization. </summary>
    public partial class LightHouseAuthorization
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

        /// <summary> Initializes a new instance of <see cref="LightHouseAuthorization"/>. </summary>
        /// <param name="principalId"></param>
        /// <param name="roleDefinitionId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="principalId"/> or <paramref name="roleDefinitionId"/> is null. </exception>
        public LightHouseAuthorization(string principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(principalId, nameof(principalId));
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> Initializes a new instance of <see cref="LightHouseAuthorization"/>. </summary>
        /// <param name="principalId"></param>
        /// <param name="roleDefinitionId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LightHouseAuthorization(string principalId, string roleDefinitionId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LightHouseAuthorization"/> for deserialization. </summary>
        internal LightHouseAuthorization()
        {
        }

        /// <summary> Gets or sets the principal id. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Gets or sets the role definition id. </summary>
        public string RoleDefinitionId { get; set; }
    }
}
