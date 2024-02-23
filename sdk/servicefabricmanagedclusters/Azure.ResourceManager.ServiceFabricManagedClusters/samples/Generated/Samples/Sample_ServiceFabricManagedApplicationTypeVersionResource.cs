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
    public partial class Sample_ServiceFabricManagedApplicationTypeVersionResource
    {
        // Get an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationTypeVersionGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeVersionResource, please refer to the document of ServiceFabricManagedApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricManagedApplicationTypeVersionResourceId = ServiceFabricManagedApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricManagedApplicationTypeVersionResource serviceFabricManagedApplicationTypeVersion = client.GetServiceFabricManagedApplicationTypeVersionResource(serviceFabricManagedApplicationTypeVersionResourceId);

            // invoke the operation
            ServiceFabricManagedApplicationTypeVersionResource result = await serviceFabricManagedApplicationTypeVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationTypeVersionPatchOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeVersionResource, please refer to the document of ServiceFabricManagedApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricManagedApplicationTypeVersionResourceId = ServiceFabricManagedApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricManagedApplicationTypeVersionResource serviceFabricManagedApplicationTypeVersion = client.GetServiceFabricManagedApplicationTypeVersionResource(serviceFabricManagedApplicationTypeVersionResourceId);

            // invoke the operation
            ServiceFabricManagedApplicationTypeVersionPatch patch = new ServiceFabricManagedApplicationTypeVersionPatch()
            {
                Tags =
{
["a"] = "b",
},
            };
            ServiceFabricManagedApplicationTypeVersionResource result = await serviceFabricManagedApplicationTypeVersion.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete an application type version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAnApplicationTypeVersion()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2023-12-01-preview/examples/ApplicationTypeVersionDeleteOperation_example.json
            // this example is just showing the usage of "ApplicationTypeVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationTypeVersionResource created on azure
            // for more information of creating ServiceFabricManagedApplicationTypeVersionResource, please refer to the document of ServiceFabricManagedApplicationTypeVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationTypeName = "myAppType";
            string version = "1.0";
            ResourceIdentifier serviceFabricManagedApplicationTypeVersionResourceId = ServiceFabricManagedApplicationTypeVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationTypeName, version);
            ServiceFabricManagedApplicationTypeVersionResource serviceFabricManagedApplicationTypeVersion = client.GetServiceFabricManagedApplicationTypeVersionResource(serviceFabricManagedApplicationTypeVersionResourceId);

            // invoke the operation
            await serviceFabricManagedApplicationTypeVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
