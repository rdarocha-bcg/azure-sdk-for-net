// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementPartner;
using Azure.ResourceManager.ManagementPartner.Models;

namespace Azure.ResourceManager.ManagementPartner.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableManagementPartnerTenantResource : ArmResource
    {
        private ClientDiagnostics _operationClientDiagnostics;
        private OperationRestOperations _operationRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableManagementPartnerTenantResource"/> class for mocking. </summary>
        protected MockableManagementPartnerTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableManagementPartnerTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableManagementPartnerTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics OperationClientDiagnostics => _operationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagementPartner", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationRestOperations OperationRestClient => _operationRestClient ??= new OperationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PartnerResponseResources in the TenantResource. </summary>
        /// <returns> An object representing collection of PartnerResponseResources and their operations over a PartnerResponseResource. </returns>
        public virtual PartnerResponseCollection GetPartnerResponses()
        {
            return GetCachedClient(client => new PartnerResponseCollection(client, Id));
        }

        /// <summary>
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PartnerResponseResource>> GetPartnerResponseAsync(string partnerId, CancellationToken cancellationToken = default)
        {
            return await GetPartnerResponses().GetAsync(partnerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PartnerResponseResource> GetPartnerResponse(string partnerId, CancellationToken cancellationToken = default)
        {
            return GetPartnerResponses().Get(partnerId, cancellationToken);
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationResponse"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationResponse> GetOperationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => OperationResponse.DeserializeOperationResponse(e), OperationClientDiagnostics, Pipeline, "MockableManagementPartnerTenantResource.GetOperations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationResponse"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationResponse> GetOperations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => OperationResponse.DeserializeOperationResponse(e), OperationClientDiagnostics, Pipeline, "MockableManagementPartnerTenantResource.GetOperations", "value", "nextLink", cancellationToken);
        }
    }
}
