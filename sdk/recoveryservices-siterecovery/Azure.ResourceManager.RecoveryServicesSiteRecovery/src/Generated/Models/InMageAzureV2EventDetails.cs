// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Model class for event details of a VMwareAzureV2 event. </summary>
    public partial class InMageAzureV2EventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2EventDetails"/>. </summary>
        internal InMageAzureV2EventDetails()
        {
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2EventDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="eventType"> InMage Event type. Takes one of the values of InMageDataContract.InMageMonitoringEventType. </param>
        /// <param name="category"> InMage Event Category. </param>
        /// <param name="component"> InMage Event Component. </param>
        /// <param name="correctiveAction"> Corrective Action string for the event. </param>
        /// <param name="details"> InMage Event Details. </param>
        /// <param name="summary"> InMage Event Summary. </param>
        /// <param name="siteName"> VMware Site name. </param>
        internal InMageAzureV2EventDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string eventType, string category, string component, string correctiveAction, string details, string summary, string siteName) : base(instanceType, serializedAdditionalRawData)
        {
            EventType = eventType;
            Category = category;
            Component = component;
            CorrectiveAction = correctiveAction;
            Details = details;
            Summary = summary;
            SiteName = siteName;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> InMage Event type. Takes one of the values of InMageDataContract.InMageMonitoringEventType. </summary>
        public string EventType { get; }
        /// <summary> InMage Event Category. </summary>
        public string Category { get; }
        /// <summary> InMage Event Component. </summary>
        public string Component { get; }
        /// <summary> Corrective Action string for the event. </summary>
        public string CorrectiveAction { get; }
        /// <summary> InMage Event Details. </summary>
        public string Details { get; }
        /// <summary> InMage Event Summary. </summary>
        public string Summary { get; }
        /// <summary> VMware Site name. </summary>
        public string SiteName { get; }
    }
}
