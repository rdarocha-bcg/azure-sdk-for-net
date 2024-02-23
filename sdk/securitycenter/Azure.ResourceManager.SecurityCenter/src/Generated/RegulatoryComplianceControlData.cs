// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the RegulatoryComplianceControl data model.
    /// Regulatory compliance control details and state
    /// </summary>
    public partial class RegulatoryComplianceControlData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="RegulatoryComplianceControlData"/>. </summary>
        public RegulatoryComplianceControlData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegulatoryComplianceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the regulatory compliance control. </param>
        /// <param name="state"> Aggregative state based on the control's supported assessments states. </param>
        /// <param name="passedAssessments"> The number of supported regulatory compliance assessments of the given control with a passed state. </param>
        /// <param name="failedAssessments"> The number of supported regulatory compliance assessments of the given control with a failed state. </param>
        /// <param name="skippedAssessments"> The number of supported regulatory compliance assessments of the given control with a skipped state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegulatoryComplianceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, RegulatoryComplianceState? state, int? passedAssessments, int? failedAssessments, int? skippedAssessments, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            State = state;
            PassedAssessments = passedAssessments;
            FailedAssessments = failedAssessments;
            SkippedAssessments = skippedAssessments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of the regulatory compliance control. </summary>
        public string Description { get; }
        /// <summary> Aggregative state based on the control's supported assessments states. </summary>
        public RegulatoryComplianceState? State { get; set; }
        /// <summary> The number of supported regulatory compliance assessments of the given control with a passed state. </summary>
        public int? PassedAssessments { get; }
        /// <summary> The number of supported regulatory compliance assessments of the given control with a failed state. </summary>
        public int? FailedAssessments { get; }
        /// <summary> The number of supported regulatory compliance assessments of the given control with a skipped state. </summary>
        public int? SkippedAssessments { get; }
    }
}
