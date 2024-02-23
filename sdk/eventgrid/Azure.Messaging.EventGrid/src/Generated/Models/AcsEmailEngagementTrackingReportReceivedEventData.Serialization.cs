// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsEmailEngagementTrackingReportReceivedEventDataConverter))]
    public partial class AcsEmailEngagementTrackingReportReceivedEventData
    {
        internal static AcsEmailEngagementTrackingReportReceivedEventData DeserializeAcsEmailEngagementTrackingReportReceivedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sender = default;
            Optional<string> recipient = default;
            Optional<string> messageId = default;
            Optional<DateTimeOffset> userActionTimeStamp = default;
            Optional<string> engagementContext = default;
            Optional<string> userAgent = default;
            Optional<AcsUserEngagement> engagementType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sender"u8))
                {
                    sender = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recipient"u8))
                {
                    recipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userActionTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userActionTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("engagementContext"u8))
                {
                    engagementContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAgent"u8))
                {
                    userAgent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("engagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    engagementType = new AcsUserEngagement(property.Value.GetString());
                    continue;
                }
            }
            return new AcsEmailEngagementTrackingReportReceivedEventData(sender.Value, recipient.Value, messageId.Value, Optional.ToNullable(userActionTimeStamp), engagementContext.Value, userAgent.Value, Optional.ToNullable(engagementType));
        }

        internal partial class AcsEmailEngagementTrackingReportReceivedEventDataConverter : JsonConverter<AcsEmailEngagementTrackingReportReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsEmailEngagementTrackingReportReceivedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsEmailEngagementTrackingReportReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsEmailEngagementTrackingReportReceivedEventData(document.RootElement);
            }
        }
    }
}
