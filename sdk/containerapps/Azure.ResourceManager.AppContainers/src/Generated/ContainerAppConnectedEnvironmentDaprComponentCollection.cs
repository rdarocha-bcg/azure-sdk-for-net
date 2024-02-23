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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> and their operations.
    /// Each <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> in the collection will belong to the same instance of <see cref="ContainerAppConnectedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppConnectedEnvironmentDaprComponentCollection"/> instance call the GetContainerAppConnectedEnvironmentDaprComponents method from an instance of <see cref="ContainerAppConnectedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppConnectedEnvironmentDaprComponentCollection : ArmCollection, IEnumerable<ContainerAppConnectedEnvironmentDaprComponentResource>, IAsyncEnumerable<ContainerAppConnectedEnvironmentDaprComponentResource>
    {
        private readonly ClientDiagnostics _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics;
        private readonly ConnectedEnvironmentsDaprComponentsRestOperations _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentDaprComponentCollection"/> class for mocking. </summary>
        protected ContainerAppConnectedEnvironmentDaprComponentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentDaprComponentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppConnectedEnvironmentDaprComponentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppConnectedEnvironmentDaprComponentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppConnectedEnvironmentDaprComponentResource.ResourceType, out string containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsApiVersion);
            _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient = new ConnectedEnvironmentsDaprComponentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppConnectedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppConnectedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Dapr Component in a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string componentName, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Dapr Component in a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource> CreateOrUpdate(WaitUntil waitUntil, string componentName, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()));
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
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppConnectedEnvironmentDaprComponentResource>> GetAsync(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<ContainerAppConnectedEnvironmentDaprComponentResource> Get(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Dapr Components for a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppConnectedEnvironmentDaprComponentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentDaprComponentResource(Client, ContainerAppDaprComponentData.DeserializeContainerAppDaprComponentData(e)), _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentDaprComponentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Dapr Components for a connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppConnectedEnvironmentDaprComponentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentDaprComponentResource(Client, ContainerAppDaprComponentData.DeserializeContainerAppDaprComponentData(e)), _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentDaprComponentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<bool> Exists(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppConnectedEnvironmentDaprComponentResource>> GetIfExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentDaprComponentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsDaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppConnectedEnvironmentDaprComponentResource> GetIfExists(string componentName, CancellationToken cancellationToken = default)
        {
            if (componentName == null)
            {
                throw new ArgumentNullException(nameof(componentName));
            }
            if (componentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(componentName));
            }

            using var scope = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentDaprComponentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentDaprComponentConnectedEnvironmentsDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentDaprComponentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppConnectedEnvironmentDaprComponentResource> IEnumerable<ContainerAppConnectedEnvironmentDaprComponentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppConnectedEnvironmentDaprComponentResource> IAsyncEnumerable<ContainerAppConnectedEnvironmentDaprComponentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
