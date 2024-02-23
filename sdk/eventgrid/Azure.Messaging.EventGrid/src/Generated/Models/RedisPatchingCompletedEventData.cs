// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Cache.PatchingCompleted event. </summary>
    public partial class RedisPatchingCompletedEventData
    {
        /// <summary> Initializes a new instance of <see cref="RedisPatchingCompletedEventData"/>. </summary>
        internal RedisPatchingCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisPatchingCompletedEventData"/>. </summary>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="name"> The name of this event. </param>
        /// <param name="status"> The status of this event. Failed or  succeeded. </param>
        internal RedisPatchingCompletedEventData(DateTimeOffset? timestamp, string name, string status)
        {
            Timestamp = timestamp;
            Name = name;
            Status = status;
        }

        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The name of this event. </summary>
        public string Name { get; }
        /// <summary> The status of this event. Failed or  succeeded. </summary>
        public string Status { get; }
    }
}
