// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Get GitHub access token request definition. </summary>
    public partial class GitHubAccessTokenContent
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

        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenContent"/>. </summary>
        /// <param name="gitHubAccessCode"> GitHub access code. </param>
        /// <param name="gitHubAccessTokenBaseUri"> GitHub access token base URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubAccessCode"/> or <paramref name="gitHubAccessTokenBaseUri"/> is null. </exception>
        public GitHubAccessTokenContent(string gitHubAccessCode, Uri gitHubAccessTokenBaseUri)
        {
            Argument.AssertNotNull(gitHubAccessCode, nameof(gitHubAccessCode));
            Argument.AssertNotNull(gitHubAccessTokenBaseUri, nameof(gitHubAccessTokenBaseUri));

            GitHubAccessCode = gitHubAccessCode;
            GitHubAccessTokenBaseUri = gitHubAccessTokenBaseUri;
        }

        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenContent"/>. </summary>
        /// <param name="gitHubAccessCode"> GitHub access code. </param>
        /// <param name="gitHubClientId"> GitHub application client ID. </param>
        /// <param name="gitHubClientSecret"> GitHub bring your own app client secret information. </param>
        /// <param name="gitHubAccessTokenBaseUri"> GitHub access token base URL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubAccessTokenContent(string gitHubAccessCode, string gitHubClientId, FactoryGitHubClientSecret gitHubClientSecret, Uri gitHubAccessTokenBaseUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GitHubAccessCode = gitHubAccessCode;
            GitHubClientId = gitHubClientId;
            GitHubClientSecret = gitHubClientSecret;
            GitHubAccessTokenBaseUri = gitHubAccessTokenBaseUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenContent"/> for deserialization. </summary>
        internal GitHubAccessTokenContent()
        {
        }

        /// <summary> GitHub access code. </summary>
        public string GitHubAccessCode { get; }
        /// <summary> GitHub application client ID. </summary>
        public string GitHubClientId { get; set; }
        /// <summary> GitHub bring your own app client secret information. </summary>
        public FactoryGitHubClientSecret GitHubClientSecret { get; set; }
        /// <summary> GitHub access token base URL. </summary>
        public Uri GitHubAccessTokenBaseUri { get; }
    }
}
