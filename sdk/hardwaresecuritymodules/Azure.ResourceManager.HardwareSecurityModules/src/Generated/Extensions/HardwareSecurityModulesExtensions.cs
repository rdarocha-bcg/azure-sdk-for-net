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
using Azure.ResourceManager.HardwareSecurityModules.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HardwareSecurityModules. </summary>
    public static partial class HardwareSecurityModulesExtensions
    {
        private static MockableHardwareSecurityModulesArmClient GetMockableHardwareSecurityModulesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHardwareSecurityModulesArmClient(client0));
        }

        private static MockableHardwareSecurityModulesResourceGroupResource GetMockableHardwareSecurityModulesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHardwareSecurityModulesResourceGroupResource(client, resource.Id));
        }

        private static MockableHardwareSecurityModulesSubscriptionResource GetMockableHardwareSecurityModulesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHardwareSecurityModulesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudHsmClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudHsmClusterResource.CreateResourceIdentifier" /> to create a <see cref="CloudHsmClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesArmClient.GetCloudHsmClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CloudHsmClusterResource"/> object. </returns>
        public static CloudHsmClusterResource GetCloudHsmClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableHardwareSecurityModulesArmClient(client).GetCloudHsmClusterResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesArmClient.GetHardwareSecurityModulesPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource"/> object. </returns>
        public static HardwareSecurityModulesPrivateEndpointConnectionResource GetHardwareSecurityModulesPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableHardwareSecurityModulesArmClient(client).GetHardwareSecurityModulesPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DedicatedHsmResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedHsmResource.CreateResourceIdentifier" /> to create a <see cref="DedicatedHsmResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesArmClient.GetDedicatedHsmResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DedicatedHsmResource"/> object. </returns>
        public static DedicatedHsmResource GetDedicatedHsmResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableHardwareSecurityModulesArmClient(client).GetDedicatedHsmResource(id);
        }

        /// <summary>
        /// Gets a collection of CloudHsmClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetCloudHsmClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of CloudHsmClusterResources and their operations over a CloudHsmClusterResource. </returns>
        public static CloudHsmClusterCollection GetCloudHsmClusters(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetCloudHsmClusters();
        }

        /// <summary>
        /// Gets the specified Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudHsmClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetCloudHsmClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="cloudHsmClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CloudHsmClusterResource>> GetCloudHsmClusterAsync(this ResourceGroupResource resourceGroupResource, string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetCloudHsmClusterAsync(cloudHsmClusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudHsmClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetCloudHsmCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 24 characters in length. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="cloudHsmClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudHsmClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CloudHsmClusterResource> GetCloudHsmCluster(this ResourceGroupResource resourceGroupResource, string cloudHsmClusterName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetCloudHsmCluster(cloudHsmClusterName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of DedicatedHsmResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetDedicatedHsms()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DedicatedHsmResources and their operations over a DedicatedHsmResource. </returns>
        public static DedicatedHsmCollection GetDedicatedHsms(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetDedicatedHsms();
        }

        /// <summary>
        /// Gets the specified Azure dedicated HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHsm_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedHsmResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetDedicatedHsmAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the dedicated HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DedicatedHsmResource>> GetDedicatedHsmAsync(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetDedicatedHsmAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Azure dedicated HSM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHsm_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedHsmResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesResourceGroupResource.GetDedicatedHsm(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the dedicated HSM. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DedicatedHsmResource> GetDedicatedHsm(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableHardwareSecurityModulesResourceGroupResource(resourceGroupResource).GetDedicatedHsm(name, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudHsmClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesSubscriptionResource.GetCloudHsmClusters(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="CloudHsmClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CloudHsmClusterResource> GetCloudHsmClustersAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableHardwareSecurityModulesSubscriptionResource(subscriptionResource).GetCloudHsmClustersAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the Cloud HSM Clusters associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudHsmClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesSubscriptionResource.GetCloudHsmClusters(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="CloudHsmClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CloudHsmClusterResource> GetCloudHsmClusters(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableHardwareSecurityModulesSubscriptionResource(subscriptionResource).GetCloudHsmClusters(skiptoken, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHsm_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedHsmResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesSubscriptionResource.GetDedicatedHsms(int?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DedicatedHsmResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DedicatedHsmResource> GetDedicatedHsmsAsync(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableHardwareSecurityModulesSubscriptionResource(subscriptionResource).GetDedicatedHsmsAsync(top, cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the dedicated HSMs associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HardwareSecurityModules/dedicatedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DedicatedHsm_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedHsmResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHardwareSecurityModulesSubscriptionResource.GetDedicatedHsms(int?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DedicatedHsmResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DedicatedHsmResource> GetDedicatedHsms(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableHardwareSecurityModulesSubscriptionResource(subscriptionResource).GetDedicatedHsms(top, cancellationToken);
        }
    }
}
