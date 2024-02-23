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
    public partial class PreValidateEnableBackupResult : IUtf8JsonSerializable, IJsonModel<PreValidateEnableBackupResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PreValidateEnableBackupResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PreValidateEnableBackupResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreValidateEnableBackupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PreValidateEnableBackupResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(Recommendation))
            {
                writer.WritePropertyName("recommendation"u8);
                writer.WriteStringValue(Recommendation);
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(ProtectedItemName))
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
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

        PreValidateEnableBackupResult IJsonModel<PreValidateEnableBackupResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreValidateEnableBackupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PreValidateEnableBackupResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePreValidateEnableBackupResult(document.RootElement, options);
        }

        internal static PreValidateEnableBackupResult DeserializePreValidateEnableBackupResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupValidationStatus> status = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> recommendation = default;
            Optional<string> containerName = default;
            Optional<string> protectedItemName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BackupValidationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendation"u8))
                {
                    recommendation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PreValidateEnableBackupResult(Optional.ToNullable(status), errorCode.Value, errorMessage.Value, recommendation.Value, containerName.Value, protectedItemName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PreValidateEnableBackupResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreValidateEnableBackupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PreValidateEnableBackupResult)} does not support '{options.Format}' format.");
            }
        }

        PreValidateEnableBackupResult IPersistableModel<PreValidateEnableBackupResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreValidateEnableBackupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePreValidateEnableBackupResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PreValidateEnableBackupResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PreValidateEnableBackupResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
