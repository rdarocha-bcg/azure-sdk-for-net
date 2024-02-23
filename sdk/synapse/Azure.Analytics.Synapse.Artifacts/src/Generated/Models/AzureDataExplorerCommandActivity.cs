// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Data Explorer command activity. </summary>
    public partial class AzureDataExplorerCommandActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="AzureDataExplorerCommandActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="command"/> is null. </exception>
        public AzureDataExplorerCommandActivity(string name, object command) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            Command = command;
            Type = "AzureDataExplorerCommand";
        }

        /// <summary> Initializes a new instance of <see cref="AzureDataExplorerCommandActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <param name="commandTimeout"> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </param>
        internal AzureDataExplorerCommandActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object command, object commandTimeout) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Command = command;
            CommandTimeout = commandTimeout;
            Type = type ?? "AzureDataExplorerCommand";
        }

        /// <summary> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </summary>
        public object Command { get; set; }
        /// <summary> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </summary>
        public object CommandTimeout { get; set; }
    }
}
