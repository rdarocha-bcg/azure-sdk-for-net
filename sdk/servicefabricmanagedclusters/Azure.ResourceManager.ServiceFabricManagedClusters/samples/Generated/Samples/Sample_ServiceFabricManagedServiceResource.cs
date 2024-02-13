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
using Azure.ResourceManager.ServiceFabricManagedClusters;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedServiceResource
    {
        // Get a service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ServiceGetOperation_example.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedServiceResource created on azure
            // for more information of creating ServiceFabricManagedServiceResource, please refer to the document of ServiceFabricManagedServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            string serviceName = "myService";
            ResourceIdentifier serviceFabricManagedServiceResourceId = ServiceFabricManagedServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
            ServiceFabricManagedServiceResource serviceFabricManagedService = client.GetServiceFabricManagedServiceResource(serviceFabricManagedServiceResourceId);

            // invoke the operation
            ServiceFabricManagedServiceResource result = await serviceFabricManagedService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch a service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ServicePatchOperation_example.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedServiceResource created on azure
            // for more information of creating ServiceFabricManagedServiceResource, please refer to the document of ServiceFabricManagedServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            string serviceName = "myService";
            ResourceIdentifier serviceFabricManagedServiceResourceId = ServiceFabricManagedServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
            ServiceFabricManagedServiceResource serviceFabricManagedService = client.GetServiceFabricManagedServiceResource(serviceFabricManagedServiceResourceId);

            // invoke the operation
            ServiceFabricManagedServicePatch patch = new ServiceFabricManagedServicePatch()
            {
                Tags =
{
["a"] = "b",
},
            };
            ServiceFabricManagedServiceResource result = await serviceFabricManagedService.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ServiceDeleteOperation_example.json
            // this example is just showing the usage of "Services_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedServiceResource created on azure
            // for more information of creating ServiceFabricManagedServiceResource, please refer to the document of ServiceFabricManagedServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            string serviceName = "myService";
            ResourceIdentifier serviceFabricManagedServiceResourceId = ServiceFabricManagedServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
            ServiceFabricManagedServiceResource serviceFabricManagedService = client.GetServiceFabricManagedServiceResource(serviceFabricManagedServiceResourceId);

            // invoke the operation
            await serviceFabricManagedService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
