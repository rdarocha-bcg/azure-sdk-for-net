// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_LoadBalancingRuleResource
    {
        // LoadBalancerLoadBalancingRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LoadBalancerLoadBalancingRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/LoadBalancerLoadBalancingRuleGet.json
            // this example is just showing the usage of "LoadBalancerLoadBalancingRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancingRuleResource created on azure
            // for more information of creating LoadBalancingRuleResource, please refer to the document of LoadBalancingRuleResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb1";
            string loadBalancingRuleName = "rule1";
            ResourceIdentifier loadBalancingRuleResourceId = LoadBalancingRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName, loadBalancingRuleName);
            LoadBalancingRuleResource loadBalancingRule = client.GetLoadBalancingRuleResource(loadBalancingRuleResourceId);

            // invoke the operation
            LoadBalancingRuleResource result = await loadBalancingRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadBalancingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
