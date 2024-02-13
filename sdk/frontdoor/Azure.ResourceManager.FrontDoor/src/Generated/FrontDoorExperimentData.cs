// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing the FrontDoorExperiment data model.
    /// Defines the properties of an Experiment
    /// </summary>
    public partial class FrontDoorExperimentData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="FrontDoorExperimentData"/>. </summary>
        /// <param name="location"> The location. </param>
        public FrontDoorExperimentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorExperimentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of the details or intents of the Experiment. </param>
        /// <param name="experimentEndpointA"> The endpoint A of an experiment. </param>
        /// <param name="experimentEndpointB"> The endpoint B of an experiment. </param>
        /// <param name="enabledState"> The state of the Experiment. </param>
        /// <param name="resourceState"> Resource status. </param>
        /// <param name="status"> The description of Experiment status from the server side. </param>
        /// <param name="scriptFileUri"> The uri to the Script used in the Experiment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorExperimentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, FrontDoorExperimentEndpointProperties experimentEndpointA, FrontDoorExperimentEndpointProperties experimentEndpointB, FrontDoorExperimentState? enabledState, NetworkExperimentResourceState? resourceState, string status, Uri scriptFileUri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            ExperimentEndpointA = experimentEndpointA;
            ExperimentEndpointB = experimentEndpointB;
            EnabledState = enabledState;
            ResourceState = resourceState;
            Status = status;
            ScriptFileUri = scriptFileUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorExperimentData"/> for deserialization. </summary>
        internal FrontDoorExperimentData()
        {
        }

        /// <summary> The description of the details or intents of the Experiment. </summary>
        public string Description { get; set; }
        /// <summary> The endpoint A of an experiment. </summary>
        public FrontDoorExperimentEndpointProperties ExperimentEndpointA { get; set; }
        /// <summary> The endpoint B of an experiment. </summary>
        public FrontDoorExperimentEndpointProperties ExperimentEndpointB { get; set; }
        /// <summary> The state of the Experiment. </summary>
        public FrontDoorExperimentState? EnabledState { get; set; }
        /// <summary> Resource status. </summary>
        public NetworkExperimentResourceState? ResourceState { get; }
        /// <summary> The description of Experiment status from the server side. </summary>
        public string Status { get; }
        /// <summary> The uri to the Script used in the Experiment. </summary>
        public Uri ScriptFileUri { get; }
    }
}
