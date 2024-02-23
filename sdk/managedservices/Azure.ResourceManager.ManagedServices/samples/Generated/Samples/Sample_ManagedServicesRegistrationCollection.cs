// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedServices;
using Azure.ResourceManager.ManagedServices.Models;

namespace Azure.ResourceManager.ManagedServices.Samples
{
    public partial class Sample_ManagedServicesRegistrationCollection
    {
        // Get Registration Definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistrationDefinition()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinition.json
            // this example is just showing the usage of "RegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation
            string registrationId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ManagedServicesRegistrationResource result = await collection.GetAsync(registrationId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registration Definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRegistrationDefinition()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinition.json
            // this example is just showing the usage of "RegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation
            string registrationId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            bool result = await collection.ExistsAsync(registrationId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Registration Definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRegistrationDefinition()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinition.json
            // this example is just showing the usage of "RegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation
            string registrationId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            NullableResponse<ManagedServicesRegistrationResource> response = await collection.GetIfExistsAsync(registrationId);
            ManagedServicesRegistrationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put Registration Definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutRegistrationDefinition()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/PutRegistrationDefinition.json
            // this example is just showing the usage of "RegistrationDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation
            string registrationId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ManagedServicesRegistrationData data = new ManagedServicesRegistrationData()
            {
                Properties = new ManagedServicesRegistrationProperties(new ManagedServicesAuthorization[]
            {
new ManagedServicesAuthorization(Guid.Parse("f98d86a2-4cc4-4e9d-ad47-b3e80a1bcdfc"),"acdd72a7-3385-48ef-bd42-f606fba81ae7")
{
PrincipalIdDisplayName = "Support User",
},new ManagedServicesAuthorization(Guid.Parse("f98d86a2-4cc4-4e9d-ad47-b3e80a1bcdfc"),"18d7d88d-d35e-4fb5-a5c3-7773c20a72d9")
{
PrincipalIdDisplayName = "User Access Administrator",
DelegatedRoleDefinitionIds =
{
Guid.Parse("b24988ac-6180-42a0-ab88-20f7382dd24c")
},
}
            }, Guid.Parse("83abe5cd-bcc3-441a-bd86-e6a75360cecc"))
                {
                    Description = "Tes1t",
                    EligibleAuthorizations =
{
new ManagedServicesEligibleAuthorization(Guid.Parse("3e0ed8c6-e902-4fc5-863c-e3ddbb2ae2a2"),"ae349356-3a1b-4a5e-921d-050484c6347e")
{
PrincipalIdDisplayName = "Support User",
JustInTimeAccessPolicy = new ManagedServicesJustInTimeAccessPolicy(MultiFactorAuthProvider.Azure)
{
MaximumActivationDuration = XmlConvert.ToTimeSpan("PT8H"),
ManagedByTenantApprovers =
{
new ManagedServicesEligibleApprover(Guid.Parse("d9b22cd6-6407-43cc-8c60-07c56df0b51a"))
{
PrincipalIdDisplayName = "Approver Group",
}
},
},
}
},
                    RegistrationDefinitionName = "DefinitionName",
                },
                Plan = new ManagedServicesPlan("addesai-plan", "marketplace-test", "test", "1.0.0"),
            };
            ArmOperation<ManagedServicesRegistrationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, registrationId, data);
            ManagedServicesRegistrationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Registration Definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinitions.json
            // this example is just showing the usage of "RegistrationDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ManagedServicesRegistrationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registration Definitions with ManagedByTenantId eq filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationDefinitionsWithManagedByTenantIdEqFilter()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinitionsWithManagedByTenantIdEqFilter.json
            // this example is just showing the usage of "RegistrationDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation and iterate over the result
            string filter = "$filter=managedByTenantId eq '83ace5cd-bcc3-441a-hd86-e6a75360cecc'";
            await foreach (ManagedServicesRegistrationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Registration Definitions with ManagedByTenantId in filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRegistrationDefinitionsWithManagedByTenantIdInFilter()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationDefinitionsWithManagedByTenantIdInFilter.json
            // this example is just showing the usage of "RegistrationDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ManagedServicesRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            ManagedServicesRegistrationCollection collection = client.GetManagedServicesRegistrations(scopeId);

            // invoke the operation and iterate over the result
            string filter = "$filter=managedByTenantId in (83ace5cd-bcc3-441a-hd86-e6a75360cecc, de83f4a9-a76a-4025-a91a-91171923eac7)";
            await foreach (ManagedServicesRegistrationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServicesRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
