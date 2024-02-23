// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The security settings of a device. </summary>
    public partial class DataBoxEdgeSecuritySettings : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSecuritySettings"/>. </summary>
        /// <param name="deviceAdminPassword"> Device administrator password as an encrypted string (encrypted using RSA PKCS #1) is used to sign into the  local web UI of the device. The Actual password should have at least 8 characters that are a combination of  uppercase, lowercase, numeric, and special characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceAdminPassword"/> is null. </exception>
        public DataBoxEdgeSecuritySettings(AsymmetricEncryptedSecret deviceAdminPassword)
        {
            if (deviceAdminPassword == null)
            {
                throw new ArgumentNullException(nameof(deviceAdminPassword));
            }

            DeviceAdminPassword = deviceAdminPassword;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSecuritySettings"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deviceAdminPassword"> Device administrator password as an encrypted string (encrypted using RSA PKCS #1) is used to sign into the  local web UI of the device. The Actual password should have at least 8 characters that are a combination of  uppercase, lowercase, numeric, and special characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeSecuritySettings(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AsymmetricEncryptedSecret deviceAdminPassword, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DeviceAdminPassword = deviceAdminPassword;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSecuritySettings"/> for deserialization. </summary>
        internal DataBoxEdgeSecuritySettings()
        {
        }

        /// <summary> Device administrator password as an encrypted string (encrypted using RSA PKCS #1) is used to sign into the  local web UI of the device. The Actual password should have at least 8 characters that are a combination of  uppercase, lowercase, numeric, and special characters. </summary>
        public AsymmetricEncryptedSecret DeviceAdminPassword { get; set; }
    }
}
