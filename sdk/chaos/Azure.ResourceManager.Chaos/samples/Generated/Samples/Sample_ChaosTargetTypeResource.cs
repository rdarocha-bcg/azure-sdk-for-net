// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ChaosTargetTypeResource
    {
        // Get a Target Type for westus2 location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetATargetTypeForWestus2Location()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2023-11-01/examples/GetTargetType.json
            // this example is just showing the usage of "TargetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetTypeResource created on azure
            // for more information of creating ChaosTargetTypeResource, please refer to the document of ChaosTargetTypeResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string locationName = "westus2";
            string targetTypeName = "Microsoft-Agent";
            ResourceIdentifier chaosTargetTypeResourceId = ChaosTargetTypeResource.CreateResourceIdentifier(subscriptionId, locationName, targetTypeName);
            ChaosTargetTypeResource chaosTargetType = client.GetChaosTargetTypeResource(chaosTargetTypeResourceId);

            // invoke the operation
            ChaosTargetTypeResource result = await chaosTargetType.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosTargetTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
