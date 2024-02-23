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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkRackResource"/> and their operations.
    /// Each <see cref="NetworkRackResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkRackCollection"/> instance call the GetNetworkRacks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkRackCollection : ArmCollection, IEnumerable<NetworkRackResource>, IAsyncEnumerable<NetworkRackResource>
    {
        private readonly ClientDiagnostics _networkRackClientDiagnostics;
        private readonly NetworkRacksRestOperations _networkRackRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkRackCollection"/> class for mocking. </summary>
        protected NetworkRackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkRackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkRackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkRackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkRackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkRackResource.ResourceType, out string networkRackApiVersion);
            _networkRackRestClient = new NetworkRacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkRackApiVersion);
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
        /// Create Network Rack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkRackResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkRackName, NetworkRackData data, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkRackRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkRackResource>(new NetworkRackOperationSource(Client), _networkRackClientDiagnostics, Pipeline, _networkRackRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Network Rack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkRackResource> CreateOrUpdate(WaitUntil waitUntil, string networkRackName, NetworkRackData data, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkRackRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkRackResource>(new NetworkRackOperationSource(Client), _networkRackClientDiagnostics, Pipeline, _networkRackRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get Network Rack resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual async Task<Response<NetworkRackResource>> GetAsync(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkRackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Network Rack resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual Response<NetworkRackResource> Get(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.Get");
            scope.Start();
            try
            {
                var response = _networkRackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Network Rack resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkRackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkRackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkRackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkRackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkRackResource(Client, NetworkRackData.DeserializeNetworkRackData(e)), _networkRackClientDiagnostics, Pipeline, "NetworkRackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Network Rack resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkRackResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkRackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkRackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkRackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkRackResource(Client, NetworkRackData.DeserializeNetworkRackData(e)), _networkRackClientDiagnostics, Pipeline, "NetworkRackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkRackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkRackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkRackResource>> GetIfExistsAsync(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkRackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkRackResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkRackResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkRacks/{networkRackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRacks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkRackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackName"> Name of the Network Rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackName"/> is null. </exception>
        public virtual NullableResponse<NetworkRackResource> GetIfExists(string networkRackName, CancellationToken cancellationToken = default)
        {
            if (networkRackName == null)
            {
                throw new ArgumentNullException(nameof(networkRackName));
            }
            if (networkRackName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkRackName));
            }

            using var scope = _networkRackClientDiagnostics.CreateScope("NetworkRackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkRackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkRackName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkRackResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkRackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkRackResource> IEnumerable<NetworkRackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkRackResource> IAsyncEnumerable<NetworkRackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
