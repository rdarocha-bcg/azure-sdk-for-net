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
    /// A class representing a collection of <see cref="ContainerAppManagedCertificateResource"/> and their operations.
    /// Each <see cref="ContainerAppManagedCertificateResource"/> in the collection will belong to the same instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppManagedCertificateCollection"/> instance call the GetContainerAppManagedCertificates method from an instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppManagedCertificateCollection : ArmCollection, IEnumerable<ContainerAppManagedCertificateResource>, IAsyncEnumerable<ContainerAppManagedCertificateResource>
    {
        private readonly ClientDiagnostics _containerAppManagedCertificateManagedCertificatesClientDiagnostics;
        private readonly ManagedCertificatesRestOperations _containerAppManagedCertificateManagedCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedCertificateCollection"/> class for mocking. </summary>
        protected ContainerAppManagedCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppManagedCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedCertificateManagedCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppManagedCertificateResource.ResourceType, out string containerAppManagedCertificateManagedCertificatesApiVersion);
            _containerAppManagedCertificateManagedCertificatesRestClient = new ManagedCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedCertificateManagedCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a Managed Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="data"> Managed Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppManagedCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedCertificateName, ContainerAppManagedCertificateData data, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppManagedCertificateManagedCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppManagedCertificateResource>(new ContainerAppManagedCertificateOperationSource(Client), _containerAppManagedCertificateManagedCertificatesClientDiagnostics, Pipeline, _containerAppManagedCertificateManagedCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or Update a Managed Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="data"> Managed Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppManagedCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string managedCertificateName, ContainerAppManagedCertificateData data, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppManagedCertificateManagedCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppManagedCertificateResource>(new ContainerAppManagedCertificateOperationSource(Client), _containerAppManagedCertificateManagedCertificatesClientDiagnostics, Pipeline, _containerAppManagedCertificateManagedCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified Managed Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppManagedCertificateResource>> GetAsync(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedCertificateManagedCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified Managed Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual Response<ContainerAppManagedCertificateResource> Get(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedCertificateManagedCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Managed Certificates in a given managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedCertificateManagedCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedCertificateManagedCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedCertificateResource(Client, ContainerAppManagedCertificateData.DeserializeContainerAppManagedCertificateData(e)), _containerAppManagedCertificateManagedCertificatesClientDiagnostics, Pipeline, "ContainerAppManagedCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Managed Certificates in a given managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedCertificateManagedCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedCertificateManagedCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedCertificateResource(Client, ContainerAppManagedCertificateData.DeserializeContainerAppManagedCertificateData(e)), _containerAppManagedCertificateManagedCertificatesClientDiagnostics, Pipeline, "ContainerAppManagedCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedCertificateManagedCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppManagedCertificateManagedCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppManagedCertificateResource>> GetIfExistsAsync(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedCertificateManagedCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/managedCertificates/{managedCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedCertificateName"> Name of the Managed Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedCertificateName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppManagedCertificateResource> GetIfExists(string managedCertificateName, CancellationToken cancellationToken = default)
        {
            if (managedCertificateName == null)
            {
                throw new ArgumentNullException(nameof(managedCertificateName));
            }
            if (managedCertificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedCertificateName));
            }

            using var scope = _containerAppManagedCertificateManagedCertificatesClientDiagnostics.CreateScope("ContainerAppManagedCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppManagedCertificateManagedCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedCertificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppManagedCertificateResource> IEnumerable<ContainerAppManagedCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppManagedCertificateResource> IAsyncEnumerable<ContainerAppManagedCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
