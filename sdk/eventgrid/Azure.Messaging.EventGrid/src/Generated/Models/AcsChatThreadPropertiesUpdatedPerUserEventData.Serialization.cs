// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadPropertiesUpdatedPerUserEventDataConverter))]
    public partial class AcsChatThreadPropertiesUpdatedPerUserEventData
    {
        internal static AcsChatThreadPropertiesUpdatedPerUserEventData DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommunicationIdentifierModel> editedByCommunicationIdentifier = default;
            Optional<DateTimeOffset> editTime = default;
            Optional<IReadOnlyDictionary<string, string>> metadata = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("editedByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("editTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadPropertiesUpdatedPerUserEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), editedByCommunicationIdentifier.Value, Optional.ToNullable(editTime), Optional.ToDictionary(metadata), Optional.ToDictionary(properties));
        }

        internal partial class AcsChatThreadPropertiesUpdatedPerUserEventDataConverter : JsonConverter<AcsChatThreadPropertiesUpdatedPerUserEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadPropertiesUpdatedPerUserEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadPropertiesUpdatedPerUserEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(document.RootElement);
            }
        }
    }
}
