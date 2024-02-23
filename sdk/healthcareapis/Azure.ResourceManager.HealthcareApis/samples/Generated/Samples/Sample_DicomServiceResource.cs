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
using Azure.ResourceManager.HealthcareApis;
using Azure.ResourceManager.HealthcareApis.Models;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_DicomServiceResource
    {
        // Get a dicomservice
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADicomservice()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2023-11-01/examples/dicomservices/DicomServices_Get.json
            // this example is just showing the usage of "DicomServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DicomServiceResource created on azure
            // for more information of creating DicomServiceResource, please refer to the document of DicomServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string dicomServiceName = "blue";
            ResourceIdentifier dicomServiceResourceId = DicomServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dicomServiceName);
            DicomServiceResource dicomService = client.GetDicomServiceResource(dicomServiceResourceId);

            // invoke the operation
            DicomServiceResource result = await dicomService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DicomServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a dicomservice
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateADicomservice()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2023-11-01/examples/dicomservices/DicomServices_Patch.json
            // this example is just showing the usage of "DicomServices_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DicomServiceResource created on azure
            // for more information of creating DicomServiceResource, please refer to the document of DicomServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string dicomServiceName = "blue";
            ResourceIdentifier dicomServiceResourceId = DicomServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dicomServiceName);
            DicomServiceResource dicomService = client.GetDicomServiceResource(dicomServiceResourceId);

            // invoke the operation
            DicomServicePatch patch = new DicomServicePatch()
            {
                Tags =
{
["tagKey"] = "tagValue",
},
            };
            ArmOperation<DicomServiceResource> lro = await dicomService.UpdateAsync(WaitUntil.Completed, patch);
            DicomServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DicomServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a dicomservice
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteADicomservice()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2023-11-01/examples/dicomservices/DicomServices_Delete.json
            // this example is just showing the usage of "DicomServices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DicomServiceResource created on azure
            // for more information of creating DicomServiceResource, please refer to the document of DicomServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string dicomServiceName = "blue";
            ResourceIdentifier dicomServiceResourceId = DicomServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dicomServiceName);
            DicomServiceResource dicomService = client.GetDicomServiceResource(dicomServiceResourceId);

            // invoke the operation
            await dicomService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
