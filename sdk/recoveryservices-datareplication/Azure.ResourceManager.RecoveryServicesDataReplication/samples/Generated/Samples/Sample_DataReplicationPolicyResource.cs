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
using Azure.ResourceManager.RecoveryServicesDataReplication;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationPolicyResource
    {
        // Policy_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PolicyGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Policy_Get.json
            // this example is just showing the usage of "Policy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationPolicyResource created on azure
            // for more information of creating DataReplicationPolicyResource, please refer to the document of DataReplicationPolicyResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string policyName = "wdqsacasc";
            ResourceIdentifier dataReplicationPolicyResourceId = DataReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, policyName);
            DataReplicationPolicyResource dataReplicationPolicy = client.GetDataReplicationPolicyResource(dataReplicationPolicyResourceId);

            // invoke the operation
            DataReplicationPolicyResource result = await dataReplicationPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Policy_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PolicyCreate()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Policy_Create.json
            // this example is just showing the usage of "Policy_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationPolicyResource created on azure
            // for more information of creating DataReplicationPolicyResource, please refer to the document of DataReplicationPolicyResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string policyName = "fafqwc";
            ResourceIdentifier dataReplicationPolicyResourceId = DataReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, policyName);
            DataReplicationPolicyResource dataReplicationPolicy = client.GetDataReplicationPolicyResource(dataReplicationPolicyResourceId);

            // invoke the operation
            DataReplicationPolicyData data = new DataReplicationPolicyData(new DataReplicationPolicyProperties(new GeneralPolicyModelCustomProperties()));
            ArmOperation<DataReplicationPolicyResource> lro = await dataReplicationPolicy.UpdateAsync(WaitUntil.Completed, data);
            DataReplicationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Policy_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PolicyDelete()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Policy_Delete.json
            // this example is just showing the usage of "Policy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationPolicyResource created on azure
            // for more information of creating DataReplicationPolicyResource, please refer to the document of DataReplicationPolicyResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string policyName = "wqfscsdv";
            ResourceIdentifier dataReplicationPolicyResourceId = DataReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, policyName);
            DataReplicationPolicyResource dataReplicationPolicy = client.GetDataReplicationPolicyResource(dataReplicationPolicyResourceId);

            // invoke the operation
            await dataReplicationPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
