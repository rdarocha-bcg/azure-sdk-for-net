// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabNotificationChannelNotifyContent : IUtf8JsonSerializable, IJsonModel<DevTestLabNotificationChannelNotifyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabNotificationChannelNotifyContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabNotificationChannelNotifyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelNotifyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationChannelNotifyContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventName))
            {
                writer.WritePropertyName("eventName"u8);
                writer.WriteStringValue(EventName.Value.ToString());
            }
            if (Optional.IsDefined(JsonPayload))
            {
                writer.WritePropertyName("jsonPayload"u8);
                writer.WriteStringValue(JsonPayload);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DevTestLabNotificationChannelNotifyContent IJsonModel<DevTestLabNotificationChannelNotifyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelNotifyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationChannelNotifyContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabNotificationChannelNotifyContent(document.RootElement, options);
        }

        internal static DevTestLabNotificationChannelNotifyContent DeserializeDevTestLabNotificationChannelNotifyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevTestLabNotificationChannelEventType> eventName = default;
            Optional<string> jsonPayload = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventName = new DevTestLabNotificationChannelEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jsonPayload"u8))
                {
                    jsonPayload = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabNotificationChannelNotifyContent(Optional.ToNullable(eventName), jsonPayload.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabNotificationChannelNotifyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelNotifyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationChannelNotifyContent)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabNotificationChannelNotifyContent IPersistableModel<DevTestLabNotificationChannelNotifyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelNotifyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabNotificationChannelNotifyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationChannelNotifyContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabNotificationChannelNotifyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
