// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory allowed principals. </summary>
    public partial class AppServiceAadAllowedPrincipals
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

        /// <summary> Initializes a new instance of <see cref="AppServiceAadAllowedPrincipals"/>. </summary>
        public AppServiceAadAllowedPrincipals()
        {
            Groups = new ChangeTrackingList<string>();
            Identities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAadAllowedPrincipals"/>. </summary>
        /// <param name="groups"> The list of the allowed groups. </param>
        /// <param name="identities"> The list of the allowed identities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceAadAllowedPrincipals(IList<string> groups, IList<string> identities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Groups = groups;
            Identities = identities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of the allowed groups. </summary>
        public IList<string> Groups { get; }
        /// <summary> The list of the allowed identities. </summary>
        public IList<string> Identities { get; }
    }
}
