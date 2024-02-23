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
    public partial class BackupResourceEncryptionConfig : IUtf8JsonSerializable, IJsonModel<BackupResourceEncryptionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceEncryptionConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupResourceEncryptionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionAtRestType))
            {
                writer.WritePropertyName("encryptionAtRestType"u8);
                writer.WriteStringValue(EncryptionAtRestType.Value.ToString());
            }
            if (Optional.IsDefined(KeyUri))
            {
                writer.WritePropertyName("keyUri"u8);
                writer.WriteStringValue(KeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(LastUpdateStatus))
            {
                writer.WritePropertyName("lastUpdateStatus"u8);
                writer.WriteStringValue(LastUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryptionState))
            {
                writer.WritePropertyName("infrastructureEncryptionState"u8);
                writer.WriteStringValue(InfrastructureEncryptionState.Value.ToString());
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

        BackupResourceEncryptionConfig IJsonModel<BackupResourceEncryptionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceEncryptionConfig(document.RootElement, options);
        }

        internal static BackupResourceEncryptionConfig DeserializeBackupResourceEncryptionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupEncryptionAtRestType> encryptionAtRestType = default;
            Optional<Uri> keyUri = default;
            Optional<string> subscriptionId = default;
            Optional<LastUpdateStatus> lastUpdateStatus = default;
            Optional<InfrastructureEncryptionState> infrastructureEncryptionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptionAtRestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtRestType = new BackupEncryptionAtRestType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateStatus = new LastUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryptionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryptionState = new InfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupResourceEncryptionConfig(Optional.ToNullable(encryptionAtRestType), keyUri.Value, subscriptionId.Value, Optional.ToNullable(lastUpdateStatus), Optional.ToNullable(infrastructureEncryptionState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupResourceEncryptionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support '{options.Format}' format.");
            }
        }

        BackupResourceEncryptionConfig IPersistableModel<BackupResourceEncryptionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupResourceEncryptionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceEncryptionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
