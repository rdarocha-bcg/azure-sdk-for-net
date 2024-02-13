// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a DefenderForStorageSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DefenderForStorageSettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDefenderForStorageSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetDefenderForStorageSetting method.
    /// </summary>
    public partial class DefenderForStorageSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DefenderForStorageSettingResource"/> instance. </summary>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="settingName"> The settingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, DefenderForStorageSettingName settingName)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _defenderForStorageSettingDefenderForStorageClientDiagnostics;
        private readonly DefenderForStorageRestOperations _defenderForStorageSettingDefenderForStorageRestClient;
        private readonly DefenderForStorageSettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/defenderForStorageSettings";

        /// <summary> Initializes a new instance of the <see cref="DefenderForStorageSettingResource"/> class for mocking. </summary>
        protected DefenderForStorageSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DefenderForStorageSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DefenderForStorageSettingResource(ArmClient client, DefenderForStorageSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DefenderForStorageSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DefenderForStorageSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _defenderForStorageSettingDefenderForStorageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string defenderForStorageSettingDefenderForStorageApiVersion);
            _defenderForStorageSettingDefenderForStorageRestClient = new DefenderForStorageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, defenderForStorageSettingDefenderForStorageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DefenderForStorageSettingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the Defender for Storage settings for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DefenderForStorageSettingResource>> GetAsync(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.GetAsync(Id.Parent, settingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Defender for Storage settings for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DefenderForStorageSettingResource> Get(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingResource.Get");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Get(Id.Parent, settingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the Defender for Storage settings on a specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DefenderForStorageSettingResource>> UpdateAsync(WaitUntil waitUntil, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.CreateAsync(Id.Parent, settingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<DefenderForStorageSettingResource>(Response.FromValue(new DefenderForStorageSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the Defender for Storage settings on a specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DefenderForStorageSettingResource> Update(WaitUntil waitUntil, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingResource.Update");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Create(Id.Parent, settingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<DefenderForStorageSettingResource>(Response.FromValue(new DefenderForStorageSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
