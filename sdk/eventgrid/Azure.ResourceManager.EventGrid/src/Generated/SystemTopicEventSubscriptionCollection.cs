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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="SystemTopicEventSubscriptionResource"/> and their operations.
    /// Each <see cref="SystemTopicEventSubscriptionResource"/> in the collection will belong to the same instance of <see cref="SystemTopicResource"/>.
    /// To get a <see cref="SystemTopicEventSubscriptionCollection"/> instance call the GetSystemTopicEventSubscriptions method from an instance of <see cref="SystemTopicResource"/>.
    /// </summary>
    public partial class SystemTopicEventSubscriptionCollection : ArmCollection, IEnumerable<SystemTopicEventSubscriptionResource>, IAsyncEnumerable<SystemTopicEventSubscriptionResource>
    {
        private readonly ClientDiagnostics _systemTopicEventSubscriptionClientDiagnostics;
        private readonly SystemTopicEventSubscriptionsRestOperations _systemTopicEventSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SystemTopicEventSubscriptionCollection"/> class for mocking. </summary>
        protected SystemTopicEventSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SystemTopicEventSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SystemTopicEventSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _systemTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", SystemTopicEventSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SystemTopicEventSubscriptionResource.ResourceType, out string systemTopicEventSubscriptionApiVersion);
            _systemTopicEventSubscriptionRestClient = new SystemTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, systemTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SystemTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SystemTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates or updates an event subscription with the specified parameters. Existing event subscriptions will be updated with this API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SystemTopicEventSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<SystemTopicEventSubscriptionResource>(new SystemTopicEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates or updates an event subscription with the specified parameters. Existing event subscriptions will be updated with this API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="data"> Event subscription properties containing the destination and filter information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SystemTopicEventSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string eventSubscriptionName, EventGridSubscriptionData data, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data, cancellationToken);
                var operation = new EventGridArmOperation<SystemTopicEventSubscriptionResource>(new SystemTopicEventSubscriptionOperationSource(Client), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, _systemTopicEventSubscriptionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<SystemTopicEventSubscriptionResource>> GetAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<SystemTopicEventSubscriptionResource> Get(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List event subscriptions that belong to a specific system topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_ListBySystemTopic</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SystemTopicEventSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SystemTopicEventSubscriptionResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _systemTopicEventSubscriptionRestClient.CreateListBySystemTopicRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _systemTopicEventSubscriptionRestClient.CreateListBySystemTopicNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SystemTopicEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, "SystemTopicEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List event subscriptions that belong to a specific system topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_ListBySystemTopic</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SystemTopicEventSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SystemTopicEventSubscriptionResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _systemTopicEventSubscriptionRestClient.CreateListBySystemTopicRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _systemTopicEventSubscriptionRestClient.CreateListBySystemTopicNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SystemTopicEventSubscriptionResource(Client, EventGridSubscriptionData.DeserializeEventGridSubscriptionData(e)), _systemTopicEventSubscriptionClientDiagnostics, Pipeline, "SystemTopicEventSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual async Task<NullableResponse<SystemTopicEventSubscriptionResource>> GetIfExistsAsync(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _systemTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SystemTopicEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new SystemTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/systemTopics/{systemTopicName}/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemTopicEventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemTopicEventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventSubscriptionName"> Name of the event subscription to be created. Event subscription names must be between 3 and 100 characters in length and use alphanumeric letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        public virtual NullableResponse<SystemTopicEventSubscriptionResource> GetIfExists(string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            if (eventSubscriptionName == null)
            {
                throw new ArgumentNullException(nameof(eventSubscriptionName));
            }
            if (eventSubscriptionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventSubscriptionName));
            }

            using var scope = _systemTopicEventSubscriptionClientDiagnostics.CreateScope("SystemTopicEventSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _systemTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventSubscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SystemTopicEventSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new SystemTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SystemTopicEventSubscriptionResource> IEnumerable<SystemTopicEventSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SystemTopicEventSubscriptionResource> IAsyncEnumerable<SystemTopicEventSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
