// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Resource metrics service provided by Microsoft.Insights resource provider. </summary>
    public partial class ServiceSpecification
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

        /// <summary> Initializes a new instance of <see cref="ServiceSpecification"/>. </summary>
        internal ServiceSpecification()
        {
            MetricSpecifications = new ChangeTrackingList<MetricSpecification>();
            LogSpecifications = new ChangeTrackingList<LogSpecification>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceSpecification"/>. </summary>
        /// <param name="metricSpecifications"></param>
        /// <param name="logSpecifications"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceSpecification(IReadOnlyList<MetricSpecification> metricSpecifications, IReadOnlyList<LogSpecification> logSpecifications, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetricSpecifications = metricSpecifications;
            LogSpecifications = logSpecifications;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the metric specifications. </summary>
        public IReadOnlyList<MetricSpecification> MetricSpecifications { get; }
        /// <summary> Gets the log specifications. </summary>
        public IReadOnlyList<LogSpecification> LogSpecifications { get; }
    }
}
