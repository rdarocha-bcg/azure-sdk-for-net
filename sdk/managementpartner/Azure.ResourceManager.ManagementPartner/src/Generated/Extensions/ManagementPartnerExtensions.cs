// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementPartner.Mocking;
using Azure.ResourceManager.ManagementPartner.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagementPartner
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ManagementPartner. </summary>
    public static partial class ManagementPartnerExtensions
    {
        private static MockableManagementPartnerArmClient GetMockableManagementPartnerArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableManagementPartnerArmClient(client0));
        }

        private static MockableManagementPartnerTenantResource GetMockableManagementPartnerTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableManagementPartnerTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerResponseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerResponseResource.CreateResourceIdentifier" /> to create a <see cref="PartnerResponseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerArmClient.GetPartnerResponseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PartnerResponseResource"/> object. </returns>
        public static PartnerResponseResource GetPartnerResponseResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableManagementPartnerArmClient(client).GetPartnerResponseResource(id);
        }

        /// <summary>
        /// Gets a collection of PartnerResponseResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerTenantResource.GetPartnerResponses()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An object representing collection of PartnerResponseResources and their operations over a PartnerResponseResource. </returns>
        public static PartnerResponseCollection GetPartnerResponses(this TenantResource tenantResource)
        {
            if (tenantResource == null)
            {
                throw new ArgumentNullException(nameof(tenantResource));
            }

            return GetMockableManagementPartnerTenantResource(tenantResource).GetPartnerResponses();
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerTenantResource.GetPartnerResponseAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="partnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PartnerResponseResource>> GetPartnerResponseAsync(this TenantResource tenantResource, string partnerId, CancellationToken cancellationToken = default)
        {
            if (tenantResource == null)
            {
                throw new ArgumentNullException(nameof(tenantResource));
            }

            return await GetMockableManagementPartnerTenantResource(tenantResource).GetPartnerResponseAsync(partnerId, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerTenantResource.GetPartnerResponse(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="partnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PartnerResponseResource> GetPartnerResponse(this TenantResource tenantResource, string partnerId, CancellationToken cancellationToken = default)
        {
            if (tenantResource == null)
            {
                throw new ArgumentNullException(nameof(tenantResource));
            }

            return GetMockableManagementPartnerTenantResource(tenantResource).GetPartnerResponse(partnerId, cancellationToken);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerTenantResource.GetOperations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="OperationResponse"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationResponse> GetOperationsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            if (tenantResource == null)
            {
                throw new ArgumentNullException(nameof(tenantResource));
            }

            return GetMockableManagementPartnerTenantResource(tenantResource).GetOperationsAsync(cancellationToken);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableManagementPartnerTenantResource.GetOperations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> A collection of <see cref="OperationResponse"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationResponse> GetOperations(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            if (tenantResource == null)
            {
                throw new ArgumentNullException(nameof(tenantResource));
            }

            return GetMockableManagementPartnerTenantResource(tenantResource).GetOperations(cancellationToken);
        }
    }
}
