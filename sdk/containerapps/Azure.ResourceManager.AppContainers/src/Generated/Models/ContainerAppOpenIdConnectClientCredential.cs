// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The authentication client credentials of the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectClientCredential
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectClientCredential"/>. </summary>
        public ContainerAppOpenIdConnectClientCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectClientCredential"/>. </summary>
        /// <param name="method"> The method that should be used to authenticate the user. </param>
        /// <param name="clientSecretSettingName"> The app setting that contains the client secret for the custom Open ID Connect provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppOpenIdConnectClientCredential(ContainerAppOpenIdConnectClientCredentialMethod? method, string clientSecretSettingName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Method = method;
            ClientSecretSettingName = clientSecretSettingName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The method that should be used to authenticate the user. </summary>
        public ContainerAppOpenIdConnectClientCredentialMethod? Method { get; set; }
        /// <summary> The app setting that contains the client secret for the custom Open ID Connect provider. </summary>
        public string ClientSecretSettingName { get; set; }
    }
}
