// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkAnalytics;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkAnalytics.Samples
{
    public partial class Sample_DataProductsCatalogResource
    {
        // DataProductsCatalogs_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDataProductsCatalogs_DataProductsCatalogsListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/networkanalytics/resource-manager/Microsoft.NetworkAnalytics/stable/2023-11-15/examples/DataProductsCatalogs_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "DataProductsCatalogs_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DataProductsCatalogResource item in subscriptionResource.GetDataProductsCatalogsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataProductsCatalogData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DataProductsCatalogs_ListBySubscription_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDataProductsCatalogs_DataProductsCatalogsListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/networkanalytics/resource-manager/Microsoft.NetworkAnalytics/stable/2023-11-15/examples/DataProductsCatalogs_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "DataProductsCatalogs_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DataProductsCatalogResource item in subscriptionResource.GetDataProductsCatalogsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataProductsCatalogData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DataProductsCatalogs_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataProductsCatalogsGetMaximumSetGen()
        {
            // Generated from example definition: specification/networkanalytics/resource-manager/Microsoft.NetworkAnalytics/stable/2023-11-15/examples/DataProductsCatalogs_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "DataProductsCatalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataProductsCatalogResource created on azure
            // for more information of creating DataProductsCatalogResource, please refer to the document of DataProductsCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "aoiresourceGroupName";
            ResourceIdentifier dataProductsCatalogResourceId = DataProductsCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            DataProductsCatalogResource dataProductsCatalog = client.GetDataProductsCatalogResource(dataProductsCatalogResourceId);

            // invoke the operation
            DataProductsCatalogResource result = await dataProductsCatalog.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataProductsCatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataProductsCatalogs_Get_MaximumSet_Gen - generated by [MinimumSet] rule_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataProductsCatalogsGetMaximumSetGenGeneratedByMinimumSetRuleMinimumSetGen()
        {
            // Generated from example definition: specification/networkanalytics/resource-manager/Microsoft.NetworkAnalytics/stable/2023-11-15/examples/DataProductsCatalogs_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "DataProductsCatalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataProductsCatalogResource created on azure
            // for more information of creating DataProductsCatalogResource, please refer to the document of DataProductsCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "aoiresourceGroupName";
            ResourceIdentifier dataProductsCatalogResourceId = DataProductsCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            DataProductsCatalogResource dataProductsCatalog = client.GetDataProductsCatalogResource(dataProductsCatalogResourceId);

            // invoke the operation
            DataProductsCatalogResource result = await dataProductsCatalog.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataProductsCatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
