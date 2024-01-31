// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SnapshotRestoreContent : IUtf8JsonSerializable, IJsonModel<SnapshotRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotRestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SkipAttachAndMount))
            {
                writer.WritePropertyName("skipAttachAndMount"u8);
                writer.WriteBooleanValue(SkipAttachAndMount.Value);
            }
            if (Optional.IsDefined(LogPointInTimeForDBRecovery))
            {
                writer.WritePropertyName("logPointInTimeForDBRecovery"u8);
                writer.WriteStringValue(LogPointInTimeForDBRecovery);
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

        SnapshotRestoreContent IJsonModel<SnapshotRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotRestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotRestoreContent(document.RootElement, options);
        }

        internal static SnapshotRestoreContent DeserializeSnapshotRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> skipAttachAndMount = default;
            Optional<string> logPointInTimeForDBRecovery = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipAttachAndMount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipAttachAndMount = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("logPointInTimeForDBRecovery"u8))
                {
                    logPointInTimeForDBRecovery = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotRestoreContent(Optional.ToNullable(skipAttachAndMount), logPointInTimeForDBRecovery.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        SnapshotRestoreContent IPersistableModel<SnapshotRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
