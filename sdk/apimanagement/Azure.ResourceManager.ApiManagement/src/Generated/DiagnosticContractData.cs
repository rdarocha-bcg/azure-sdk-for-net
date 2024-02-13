// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the DiagnosticContract data model.
    /// Diagnostic details.
    /// </summary>
    public partial class DiagnosticContractData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticContractData"/>. </summary>
        public DiagnosticContractData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alwaysLog"> Specifies for what type of messages sampling settings should not apply. </param>
        /// <param name="loggerId"> Resource Id of a target logger. </param>
        /// <param name="sampling"> Sampling settings for Diagnostic. </param>
        /// <param name="frontend"> Diagnostic settings for incoming/outgoing HTTP messages to the Gateway. </param>
        /// <param name="backend"> Diagnostic settings for incoming/outgoing HTTP messages to the Backend. </param>
        /// <param name="isLogClientIPEnabled"> Log the ClientIP. Default is false. </param>
        /// <param name="httpCorrelationProtocol"> Sets correlation protocol to use for Application Insights diagnostics. </param>
        /// <param name="verbosity"> The verbosity level applied to traces emitted by trace policies. </param>
        /// <param name="operationNameFormat"> The format of the Operation Name for Application Insights telemetries. Default is Name. </param>
        /// <param name="metrics"> Emit custom metrics via emit-metric policy. Applicable only to Application Insights diagnostic settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlwaysLog? alwaysLog, string loggerId, SamplingSettings sampling, PipelineDiagnosticSettings frontend, PipelineDiagnosticSettings backend, bool? isLogClientIPEnabled, HttpCorrelationProtocol? httpCorrelationProtocol, TraceVerbosityLevel? verbosity, OperationNameFormat? operationNameFormat, bool? metrics, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AlwaysLog = alwaysLog;
            LoggerId = loggerId;
            Sampling = sampling;
            Frontend = frontend;
            Backend = backend;
            IsLogClientIPEnabled = isLogClientIPEnabled;
            HttpCorrelationProtocol = httpCorrelationProtocol;
            Verbosity = verbosity;
            OperationNameFormat = operationNameFormat;
            Metrics = metrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies for what type of messages sampling settings should not apply. </summary>
        public AlwaysLog? AlwaysLog { get; set; }
        /// <summary> Resource Id of a target logger. </summary>
        public string LoggerId { get; set; }
        /// <summary> Sampling settings for Diagnostic. </summary>
        public SamplingSettings Sampling { get; set; }
        /// <summary> Diagnostic settings for incoming/outgoing HTTP messages to the Gateway. </summary>
        public PipelineDiagnosticSettings Frontend { get; set; }
        /// <summary> Diagnostic settings for incoming/outgoing HTTP messages to the Backend. </summary>
        public PipelineDiagnosticSettings Backend { get; set; }
        /// <summary> Log the ClientIP. Default is false. </summary>
        public bool? IsLogClientIPEnabled { get; set; }
        /// <summary> Sets correlation protocol to use for Application Insights diagnostics. </summary>
        public HttpCorrelationProtocol? HttpCorrelationProtocol { get; set; }
        /// <summary> The verbosity level applied to traces emitted by trace policies. </summary>
        public TraceVerbosityLevel? Verbosity { get; set; }
        /// <summary> The format of the Operation Name for Application Insights telemetries. Default is Name. </summary>
        public OperationNameFormat? OperationNameFormat { get; set; }
        /// <summary> Emit custom metrics via emit-metric policy. Applicable only to Application Insights diagnostic settings. </summary>
        public bool? Metrics { get; set; }
    }
}
