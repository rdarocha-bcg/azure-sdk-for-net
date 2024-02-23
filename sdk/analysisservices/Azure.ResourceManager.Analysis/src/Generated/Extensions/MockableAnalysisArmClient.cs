// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Analysis;

namespace Azure.ResourceManager.Analysis.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAnalysisArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAnalysisArmClient"/> class for mocking. </summary>
        protected MockableAnalysisArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAnalysisArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAnalysisArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAnalysisArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AnalysisServerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AnalysisServerResource.CreateResourceIdentifier" /> to create an <see cref="AnalysisServerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnalysisServerResource"/> object. </returns>
        public virtual AnalysisServerResource GetAnalysisServerResource(ResourceIdentifier id)
        {
            AnalysisServerResource.ValidateResourceId(id);
            return new AnalysisServerResource(Client, id);
        }
    }
}
