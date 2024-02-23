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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingAccountPaymentMethodResource"/> and their operations.
    /// Each <see cref="BillingAccountPaymentMethodResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="BillingAccountPaymentMethodCollection"/> instance call the GetBillingAccountPaymentMethods method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class BillingAccountPaymentMethodCollection : ArmCollection, IEnumerable<BillingAccountPaymentMethodResource>, IAsyncEnumerable<BillingAccountPaymentMethodResource>
    {
        private readonly ClientDiagnostics _billingAccountPaymentMethodPaymentMethodsClientDiagnostics;
        private readonly PaymentMethodsRestOperations _billingAccountPaymentMethodPaymentMethodsRestClient;
        private readonly string _billingAccountName;

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPaymentMethodCollection"/> class for mocking. </summary>
        protected BillingAccountPaymentMethodCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPaymentMethodCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BillingAccountPaymentMethodCollection(ArmClient client, ResourceIdentifier id, string billingAccountName) : base(client, id)
        {
            _billingAccountName = billingAccountName;
            _billingAccountPaymentMethodPaymentMethodsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingAccountPaymentMethodResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingAccountPaymentMethodResource.ResourceType, out string billingAccountPaymentMethodPaymentMethodsApiVersion);
            _billingAccountPaymentMethodPaymentMethodsRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAccountPaymentMethodPaymentMethodsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<Response<BillingAccountPaymentMethodResource>> GetAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccountAsync(_billingAccountName, paymentMethodName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual Response<BillingAccountPaymentMethodResource> Get(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccount(_billingAccountName, paymentMethodName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the payment methods available for a billing account. Along with the payment methods owned by the caller, these payment methods can be attached to a billing profile to make payments. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingAccountPaymentMethodResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingAccountPaymentMethodResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAccountPaymentMethodPaymentMethodsRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAccountPaymentMethodPaymentMethodsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingAccountPaymentMethodResource(Client, BillingPaymentMethodData.DeserializeBillingPaymentMethodData(e)), _billingAccountPaymentMethodPaymentMethodsClientDiagnostics, Pipeline, "BillingAccountPaymentMethodCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the payment methods available for a billing account. Along with the payment methods owned by the caller, these payment methods can be attached to a billing profile to make payments. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingAccountPaymentMethodResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingAccountPaymentMethodResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAccountPaymentMethodPaymentMethodsRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAccountPaymentMethodPaymentMethodsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingAccountPaymentMethodResource(Client, BillingPaymentMethodData.DeserializeBillingPaymentMethodData(e)), _billingAccountPaymentMethodPaymentMethodsClientDiagnostics, Pipeline, "BillingAccountPaymentMethodCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccountAsync(_billingAccountName, paymentMethodName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual Response<bool> Exists(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccount(_billingAccountName, paymentMethodName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingAccountPaymentMethodResource>> GetIfExistsAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccountAsync(_billingAccountName, paymentMethodName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingAccountPaymentMethodResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual NullableResponse<BillingAccountPaymentMethodResource> GetIfExists(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            if (paymentMethodName == null)
            {
                throw new ArgumentNullException(nameof(paymentMethodName));
            }
            if (paymentMethodName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(paymentMethodName));
            }

            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccount(_billingAccountName, paymentMethodName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingAccountPaymentMethodResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingAccountPaymentMethodResource> IEnumerable<BillingAccountPaymentMethodResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingAccountPaymentMethodResource> IAsyncEnumerable<BillingAccountPaymentMethodResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
