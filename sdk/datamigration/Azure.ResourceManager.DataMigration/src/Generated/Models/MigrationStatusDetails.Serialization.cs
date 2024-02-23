// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrationStatusDetails : IUtf8JsonSerializable, IJsonModel<MigrationStatusDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationStatusDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrationStatusDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationStatusDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteStringValue(MigrationState);
            }
            if (options.Format != "W" && Optional.IsDefined(FullBackupSetInfo))
            {
                writer.WritePropertyName("fullBackupSetInfo"u8);
                writer.WriteObjectValue(FullBackupSetInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRestoredBackupSetInfo))
            {
                writer.WritePropertyName("lastRestoredBackupSetInfo"u8);
                writer.WriteObjectValue(LastRestoredBackupSetInfo);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ActiveBackupSets))
            {
                writer.WritePropertyName("activeBackupSets"u8);
                writer.WriteStartArray();
                foreach (var item in ActiveBackupSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InvalidFiles))
            {
                writer.WritePropertyName("invalidFiles"u8);
                writer.WriteStartArray();
                foreach (var item in InvalidFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(BlobContainerName))
            {
                writer.WritePropertyName("blobContainerName"u8);
                writer.WriteStringValue(BlobContainerName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsFullBackupRestored))
            {
                writer.WritePropertyName("isFullBackupRestored"u8);
                writer.WriteBooleanValue(IsFullBackupRestored.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RestoreBlockingReason))
            {
                writer.WritePropertyName("restoreBlockingReason"u8);
                writer.WriteStringValue(RestoreBlockingReason);
            }
            if (options.Format != "W" && Optional.IsDefined(CompleteRestoreErrorMessage))
            {
                writer.WritePropertyName("completeRestoreErrorMessage"u8);
                writer.WriteStringValue(CompleteRestoreErrorMessage);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FileUploadBlockingErrors))
            {
                writer.WritePropertyName("fileUploadBlockingErrors"u8);
                writer.WriteStartArray();
                foreach (var item in FileUploadBlockingErrors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentRestoringFilename))
            {
                writer.WritePropertyName("currentRestoringFilename"u8);
                writer.WriteStringValue(CurrentRestoringFilename);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRestoredFilename))
            {
                writer.WritePropertyName("lastRestoredFilename"u8);
                writer.WriteStringValue(LastRestoredFilename);
            }
            if (options.Format != "W" && Optional.IsDefined(PendingLogBackupsCount))
            {
                writer.WritePropertyName("pendingLogBackupsCount"u8);
                writer.WriteNumberValue(PendingLogBackupsCount.Value);
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

        MigrationStatusDetails IJsonModel<MigrationStatusDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationStatusDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationStatusDetails(document.RootElement, options);
        }

        internal static MigrationStatusDetails DeserializeMigrationStatusDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> migrationState = default;
            Optional<SqlBackupSetInfo> fullBackupSetInfo = default;
            Optional<SqlBackupSetInfo> lastRestoredBackupSetInfo = default;
            Optional<IReadOnlyList<SqlBackupSetInfo>> activeBackupSets = default;
            Optional<IReadOnlyList<string>> invalidFiles = default;
            Optional<string> blobContainerName = default;
            Optional<bool> isFullBackupRestored = default;
            Optional<string> restoreBlockingReason = default;
            Optional<string> completeRestoreErrorMessage = default;
            Optional<IReadOnlyList<string>> fileUploadBlockingErrors = default;
            Optional<string> currentRestoringFilename = default;
            Optional<string> lastRestoredFilename = default;
            Optional<int> pendingLogBackupsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationState"u8))
                {
                    migrationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupSetInfo = SqlBackupSetInfo.DeserializeSqlBackupSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastRestoredBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRestoredBackupSetInfo = SqlBackupSetInfo.DeserializeSqlBackupSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("activeBackupSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlBackupSetInfo> array = new List<SqlBackupSetInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlBackupSetInfo.DeserializeSqlBackupSetInfo(item, options));
                    }
                    activeBackupSets = array;
                    continue;
                }
                if (property.NameEquals("invalidFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidFiles = array;
                    continue;
                }
                if (property.NameEquals("blobContainerName"u8))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isFullBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFullBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restoreBlockingReason"u8))
                {
                    restoreBlockingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("completeRestoreErrorMessage"u8))
                {
                    completeRestoreErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileUploadBlockingErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fileUploadBlockingErrors = array;
                    continue;
                }
                if (property.NameEquals("currentRestoringFilename"u8))
                {
                    currentRestoringFilename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRestoredFilename"u8))
                {
                    lastRestoredFilename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pendingLogBackupsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingLogBackupsCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrationStatusDetails(migrationState.Value, fullBackupSetInfo.Value, lastRestoredBackupSetInfo.Value, Optional.ToList(activeBackupSets), Optional.ToList(invalidFiles), blobContainerName.Value, Optional.ToNullable(isFullBackupRestored), restoreBlockingReason.Value, completeRestoreErrorMessage.Value, Optional.ToList(fileUploadBlockingErrors), currentRestoringFilename.Value, lastRestoredFilename.Value, Optional.ToNullable(pendingLogBackupsCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationStatusDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationStatusDetails)} does not support '{options.Format}' format.");
            }
        }

        MigrationStatusDetails IPersistableModel<MigrationStatusDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationStatusDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationStatusDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationStatusDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationStatusDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
