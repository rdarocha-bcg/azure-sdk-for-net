// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualRouterResource"/> and their operations.
    /// Each <see cref="VirtualRouterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VirtualRouterCollection"/> instance call the GetVirtualRouters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VirtualRouterCollection : ArmCollection, IEnumerable<VirtualRouterResource>, IAsyncEnumerable<VirtualRouterResource>
    {
        private readonly ClientDiagnostics _virtualRouterClientDiagnostics;
        private readonly VirtualRoutersRestOperations _virtualRouterRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterCollection"/> class for mocking. </summary>
        protected VirtualRouterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualRouterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualRouterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualRouterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualRouterResource.ResourceType, out string virtualRouterApiVersion);
            _virtualRouterRestClient = new VirtualRoutersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualRouterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="data"> Parameters supplied to the create or update Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualRouterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualRouterName, VirtualRouterData data, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualRouterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualRouterResource>(new VirtualRouterOperationSource(Client), _virtualRouterClientDiagnostics, Pipeline, _virtualRouterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="data"> Parameters supplied to the create or update Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualRouterResource> CreateOrUpdate(WaitUntil waitUntil, string virtualRouterName, VirtualRouterData data, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualRouterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualRouterResource>(new VirtualRouterOperationSource(Client), _virtualRouterClientDiagnostics, Pipeline, _virtualRouterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual async Task<Response<VirtualRouterResource>> GetAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualRouterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Virtual Router.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual Response<VirtualRouterResource> Get(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualRouterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Virtual Routers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualRouterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualRouterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualRouterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualRouterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualRouterResource(Client, VirtualRouterData.DeserializeVirtualRouterData(e)), _virtualRouterClientDiagnostics, Pipeline, "VirtualRouterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Virtual Routers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualRouterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualRouterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualRouterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualRouterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualRouterResource(Client, VirtualRouterData.DeserializeVirtualRouterData(e)), _virtualRouterClientDiagnostics, Pipeline, "VirtualRouterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualRouterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualRouterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualRouterResource>> GetIfExistsAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualRouterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualRouterResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualRouters/{virtualRouterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualRouters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualRouterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual NullableResponse<VirtualRouterResource> GetIfExists(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualRouterName == null)
            {
                throw new ArgumentNullException(nameof(virtualRouterName));
            }
            if (virtualRouterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(virtualRouterName));
            }

            using var scope = _virtualRouterClientDiagnostics.CreateScope("VirtualRouterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualRouterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualRouterResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualRouterResource> IEnumerable<VirtualRouterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualRouterResource> IAsyncEnumerable<VirtualRouterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
