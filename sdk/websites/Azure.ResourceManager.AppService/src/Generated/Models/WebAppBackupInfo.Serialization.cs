// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppBackupInfo : IUtf8JsonSerializable, IJsonModel<WebAppBackupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppBackupInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppBackupInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppBackupInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupName))
            {
                writer.WritePropertyName("backupName"u8);
                writer.WriteStringValue(BackupName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BackupSchedule))
            {
                writer.WritePropertyName("backupSchedule"u8);
                writer.WriteObjectValue(BackupSchedule);
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        WebAppBackupInfo IJsonModel<WebAppBackupInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppBackupInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppBackupInfo(document.RootElement, options);
        }

        internal static WebAppBackupInfo DeserializeWebAppBackupInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> backupName = default;
            Optional<bool> enabled = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<WebAppBackupSchedule> backupSchedule = default;
            Optional<IList<AppServiceDatabaseBackupSetting>> databases = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("backupName"u8))
                        {
                            backupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("backupSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupSchedule = WebAppBackupSchedule.DeserializeWebAppBackupSchedule(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceDatabaseBackupSetting> array = new List<AppServiceDatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceDatabaseBackupSetting.DeserializeAppServiceDatabaseBackupSetting(item, options));
                            }
                            databases = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppBackupInfo(id, name, type, systemData.Value, backupName.Value, Optional.ToNullable(enabled), storageAccountUrl.Value, backupSchedule.Value, Optional.ToList(databases), kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppBackupInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppBackupInfo)} does not support '{options.Format}' format.");
            }
        }

        WebAppBackupInfo IPersistableModel<WebAppBackupInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppBackupInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppBackupInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppBackupInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
