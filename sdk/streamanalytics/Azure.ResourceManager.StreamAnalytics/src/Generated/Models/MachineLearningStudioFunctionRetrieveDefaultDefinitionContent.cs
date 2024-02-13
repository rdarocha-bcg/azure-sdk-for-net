// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The parameters needed to retrieve the default function definition for an Azure Machine Learning Studio function. </summary>
    public partial class MachineLearningStudioFunctionRetrieveDefaultDefinitionContent : FunctionRetrieveDefaultDefinitionContent
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioFunctionRetrieveDefaultDefinitionContent"/>. </summary>
        public MachineLearningStudioFunctionRetrieveDefaultDefinitionContent()
        {
            BindingType = "Microsoft.MachineLearning/WebService";
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioFunctionRetrieveDefaultDefinitionContent"/>. </summary>
        /// <param name="bindingType"> Indicates the function binding type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="executeEndpoint"> The Request-Response execute endpoint of the Azure Machine Learning Studio. Find out more here: https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs. </param>
        /// <param name="udfType"> The function type. </param>
        internal MachineLearningStudioFunctionRetrieveDefaultDefinitionContent(string bindingType, IDictionary<string, BinaryData> serializedAdditionalRawData, string executeEndpoint, StreamingJobFunctionUdfType? udfType) : base(bindingType, serializedAdditionalRawData)
        {
            ExecuteEndpoint = executeEndpoint;
            UdfType = udfType;
            BindingType = bindingType ?? "Microsoft.MachineLearning/WebService";
        }

        /// <summary> The Request-Response execute endpoint of the Azure Machine Learning Studio. Find out more here: https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs. </summary>
        public string ExecuteEndpoint { get; set; }
        /// <summary> The function type. </summary>
        public StreamingJobFunctionUdfType? UdfType { get; set; }
    }
}
