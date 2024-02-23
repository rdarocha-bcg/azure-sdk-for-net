// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The multi-region account key of an Azure AI service resource that's attached to a skillset. </summary>
    public partial class CognitiveServicesAccountKey : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountKey"/>. </summary>
        /// <param name="key"> The key used to provision the Azure AI service resource attached to a skillset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public CognitiveServicesAccountKey(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            ODataType = "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountKey"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of Azure AI service resource attached to a skillset. </param>
        /// <param name="description"> Description of the Azure AI service resource attached to a skillset. </param>
        /// <param name="key"> The key used to provision the Azure AI service resource attached to a skillset. </param>
        internal CognitiveServicesAccountKey(string oDataType, string description, string key) : base(oDataType, description)
        {
            Key = key;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> The key used to provision the Azure AI service resource attached to a skillset. </summary>
        public string Key { get; set; }
    }
}
