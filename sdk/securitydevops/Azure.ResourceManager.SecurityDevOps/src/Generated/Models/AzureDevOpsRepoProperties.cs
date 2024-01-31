// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> AzureDevOps Repo properties. </summary>
    public partial class AzureDevOpsRepoProperties
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

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsRepoProperties"/>. </summary>
        public AzureDevOpsRepoProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsRepoProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="repoId"> Gets or sets Azure DevOps repo id. </param>
        /// <param name="repoUri"> Gets or sets AzureDevOps repo url. </param>
        /// <param name="orgName"> Gets or sets AzureDevOps Org Name. </param>
        /// <param name="projectName"> Gets or sets AzureDevOps Project Name. </param>
        /// <param name="visibility"> Gets or sets AzureDevOps repo visibility, whether it is public or private etc. </param>
        /// <param name="actionableRemediation"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsRepoProperties(ProvisioningState? provisioningState, string repoId, Uri repoUri, string orgName, string projectName, string visibility, ActionableRemediation actionableRemediation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            RepoId = repoId;
            RepoUri = repoUri;
            OrgName = orgName;
            ProjectName = projectName;
            Visibility = visibility;
            ActionableRemediation = actionableRemediation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets Azure DevOps repo id. </summary>
        public string RepoId { get; set; }
        /// <summary> Gets or sets AzureDevOps repo url. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> Gets or sets AzureDevOps Org Name. </summary>
        public string OrgName { get; set; }
        /// <summary> Gets or sets AzureDevOps Project Name. </summary>
        public string ProjectName { get; set; }
        /// <summary> Gets or sets AzureDevOps repo visibility, whether it is public or private etc. </summary>
        public string Visibility { get; set; }
        /// <summary> Gets or sets the actionable remediation. </summary>
        public ActionableRemediation ActionableRemediation { get; set; }
    }
}
