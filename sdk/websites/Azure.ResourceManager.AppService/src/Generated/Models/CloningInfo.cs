// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Information needed for cloning operation. </summary>
    public partial class CloningInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloningInfo"/>. </summary>
        /// <param name="sourceWebAppId">
        /// ARM resource ID of the source app. App resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceWebAppId"/> is null. </exception>
        public CloningInfo(ResourceIdentifier sourceWebAppId)
        {
            if (sourceWebAppId == null)
            {
                throw new ArgumentNullException(nameof(sourceWebAppId));
            }

            SourceWebAppId = sourceWebAppId;
            AppSettingsOverrides = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloningInfo"/>. </summary>
        /// <param name="correlationId">
        /// Correlation ID of cloning operation. This ID ties multiple cloning operations
        /// together to use the same snapshot.
        /// </param>
        /// <param name="canOverwrite"> &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cloneCustomHostNames"> &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cloneSourceControl"> &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="sourceWebAppId">
        /// ARM resource ID of the source app. App resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// </param>
        /// <param name="sourceWebAppLocation"> Location of source app ex: West US or North Europe. </param>
        /// <param name="hostingEnvironment"> App Service Environment. </param>
        /// <param name="appSettingsOverrides">
        /// Application setting overrides for cloned app. If specified, these settings override the settings cloned
        /// from source app. Otherwise, application settings from source app are retained.
        /// </param>
        /// <param name="configureLoadBalancing"> &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app. </param>
        /// <param name="trafficManagerProfileId">
        /// ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
        /// </param>
        /// <param name="trafficManagerProfileName"> Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloningInfo(Guid? correlationId, bool? canOverwrite, bool? cloneCustomHostNames, bool? cloneSourceControl, ResourceIdentifier sourceWebAppId, AzureLocation? sourceWebAppLocation, string hostingEnvironment, IDictionary<string, string> appSettingsOverrides, bool? configureLoadBalancing, ResourceIdentifier trafficManagerProfileId, string trafficManagerProfileName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CorrelationId = correlationId;
            CanOverwrite = canOverwrite;
            CloneCustomHostNames = cloneCustomHostNames;
            CloneSourceControl = cloneSourceControl;
            SourceWebAppId = sourceWebAppId;
            SourceWebAppLocation = sourceWebAppLocation;
            HostingEnvironment = hostingEnvironment;
            AppSettingsOverrides = appSettingsOverrides;
            ConfigureLoadBalancing = configureLoadBalancing;
            TrafficManagerProfileId = trafficManagerProfileId;
            TrafficManagerProfileName = trafficManagerProfileName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CloningInfo"/> for deserialization. </summary>
        internal CloningInfo()
        {
        }

        /// <summary>
        /// Correlation ID of cloning operation. This ID ties multiple cloning operations
        /// together to use the same snapshot.
        /// </summary>
        public Guid? CorrelationId { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? CanOverwrite { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? CloneCustomHostNames { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to clone source control from source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? CloneSourceControl { get; set; }
        /// <summary>
        /// ARM resource ID of the source app. App resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
        /// </summary>
        public ResourceIdentifier SourceWebAppId { get; set; }
        /// <summary> Location of source app ex: West US or North Europe. </summary>
        public AzureLocation? SourceWebAppLocation { get; set; }
        /// <summary> App Service Environment. </summary>
        public string HostingEnvironment { get; set; }
        /// <summary>
        /// Application setting overrides for cloned app. If specified, these settings override the settings cloned
        /// from source app. Otherwise, application settings from source app are retained.
        /// </summary>
        public IDictionary<string, string> AppSettingsOverrides { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to configure load balancing for source and destination app. </summary>
        public bool? ConfigureLoadBalancing { get; set; }
        /// <summary>
        /// ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
        /// </summary>
        public ResourceIdentifier TrafficManagerProfileId { get; set; }
        /// <summary> Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist. </summary>
        public string TrafficManagerProfileName { get; set; }
    }
}
