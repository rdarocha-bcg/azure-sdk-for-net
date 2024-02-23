// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryManagedVirtualNetworkCollection
    {
        // ManagedVirtualNetworks_ListByFactory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ManagedVirtualNetworksListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_ListByFactory.json
            // this example is just showing the usage of "ManagedVirtualNetworks_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryManagedVirtualNetworkResource
            DataFactoryManagedVirtualNetworkCollection collection = dataFactory.GetDataFactoryManagedVirtualNetworks();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryManagedVirtualNetworkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryManagedVirtualNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ManagedVirtualNetworks_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ManagedVirtualNetworksCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Create.json
            // this example is just showing the usage of "ManagedVirtualNetworks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryManagedVirtualNetworkResource
            DataFactoryManagedVirtualNetworkCollection collection = dataFactory.GetDataFactoryManagedVirtualNetworks();

            // invoke the operation
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            DataFactoryManagedVirtualNetworkData data = new DataFactoryManagedVirtualNetworkData(new DataFactoryManagedVirtualNetworkProperties());
            ArmOperation<DataFactoryManagedVirtualNetworkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, managedVirtualNetworkName, data);
            DataFactoryManagedVirtualNetworkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryManagedVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedVirtualNetworks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedVirtualNetworksGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Get.json
            // this example is just showing the usage of "ManagedVirtualNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryManagedVirtualNetworkResource
            DataFactoryManagedVirtualNetworkCollection collection = dataFactory.GetDataFactoryManagedVirtualNetworks();

            // invoke the operation
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            DataFactoryManagedVirtualNetworkResource result = await collection.GetAsync(managedVirtualNetworkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryManagedVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedVirtualNetworks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ManagedVirtualNetworksGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Get.json
            // this example is just showing the usage of "ManagedVirtualNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryManagedVirtualNetworkResource
            DataFactoryManagedVirtualNetworkCollection collection = dataFactory.GetDataFactoryManagedVirtualNetworks();

            // invoke the operation
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            bool result = await collection.ExistsAsync(managedVirtualNetworkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ManagedVirtualNetworks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ManagedVirtualNetworksGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Get.json
            // this example is just showing the usage of "ManagedVirtualNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryManagedVirtualNetworkResource
            DataFactoryManagedVirtualNetworkCollection collection = dataFactory.GetDataFactoryManagedVirtualNetworks();

            // invoke the operation
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            NullableResponse<DataFactoryManagedVirtualNetworkResource> response = await collection.GetIfExistsAsync(managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryManagedVirtualNetworkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
