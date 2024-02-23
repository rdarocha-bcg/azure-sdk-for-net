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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryRunResource"/> and their operations.
    /// Each <see cref="ContainerRegistryRunResource"/> in the collection will belong to the same instance of <see cref="ContainerRegistryResource"/>.
    /// To get a <see cref="ContainerRegistryRunCollection"/> instance call the GetContainerRegistryRuns method from an instance of <see cref="ContainerRegistryResource"/>.
    /// </summary>
    public partial class ContainerRegistryRunCollection : ArmCollection, IEnumerable<ContainerRegistryRunResource>, IAsyncEnumerable<ContainerRegistryRunResource>
    {
        private readonly ClientDiagnostics _containerRegistryRunRunsClientDiagnostics;
        private readonly RunsRestOperations _containerRegistryRunRunsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryRunCollection"/> class for mocking. </summary>
        protected ContainerRegistryRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryRunRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryRunResource.ResourceType, out string containerRegistryRunRunsApiVersion);
            _containerRegistryRunRunsRestClient = new RunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryRunRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the detailed information for a given run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryRunResource>> GetAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information for a given run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual Response<ContainerRegistryRunResource> Get(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the runs for a registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The runs filter to apply on the operation. Arithmetic operators are not supported. The allowed string function is 'contains'. All logical operators except 'Not', 'Has', 'All' are allowed. </param>
        /// <param name="top"> $top is supported for get list of runs, which limits the maximum number of runs to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryRunResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryRunRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryRunRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryRunResource(Client, ContainerRegistryRunData.DeserializeContainerRegistryRunData(e)), _containerRegistryRunRunsClientDiagnostics, Pipeline, "ContainerRegistryRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the runs for a registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The runs filter to apply on the operation. Arithmetic operators are not supported. The allowed string function is 'contains'. All logical operators except 'Not', 'Has', 'All' are allowed. </param>
        /// <param name="top"> $top is supported for get list of runs, which limits the maximum number of runs to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryRunResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryRunResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryRunRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryRunRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryRunResource(Client, ContainerRegistryRunData.DeserializeContainerRegistryRunData(e)), _containerRegistryRunRunsClientDiagnostics, Pipeline, "ContainerRegistryRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual Response<bool> Exists(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerRegistryRunResource>> GetIfExistsAsync(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerRegistryRunRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryRunResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/runs/{runId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Runs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryRunResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runId"> The run ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        public virtual NullableResponse<ContainerRegistryRunResource> GetIfExists(string runId, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(runId));
            }

            using var scope = _containerRegistryRunRunsClientDiagnostics.CreateScope("ContainerRegistryRunCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerRegistryRunRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryRunResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryRunResource> IEnumerable<ContainerRegistryRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryRunResource> IAsyncEnumerable<ContainerRegistryRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
