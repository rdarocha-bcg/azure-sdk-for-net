// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Append value for a Variable of type Array. </summary>
    public partial class AppendVariableActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of <see cref="AppendVariableActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AppendVariableActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ActivityType = "AppendVariable";
        }

        /// <summary> Initializes a new instance of <see cref="AppendVariableActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="variableName"> Name of the variable whose value needs to be appended to. </param>
        /// <param name="value"> Value to be appended. Type: could be a static value matching type of the variable item or Expression with resultType matching type of the variable item. </param>
        internal AppendVariableActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, string variableName, DataFactoryElement<BinaryData> value) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            VariableName = variableName;
            Value = value;
            ActivityType = activityType ?? "AppendVariable";
        }

        /// <summary> Initializes a new instance of <see cref="AppendVariableActivity"/> for deserialization. </summary>
        internal AppendVariableActivity()
        {
        }

        /// <summary> Name of the variable whose value needs to be appended to. </summary>
        public string VariableName { get; set; }
        /// <summary> Value to be appended. Type: could be a static value matching type of the variable item or Expression with resultType matching type of the variable item. </summary>
        public DataFactoryElement<BinaryData> Value { get; set; }
    }
}
