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
    public partial class RecoveryPointDiskConfiguration : IUtf8JsonSerializable, IJsonModel<RecoveryPointDiskConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointDiskConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPointDiskConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointDiskConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NumberOfDisksIncludedInBackup))
            {
                writer.WritePropertyName("numberOfDisksIncludedInBackup"u8);
                writer.WriteNumberValue(NumberOfDisksIncludedInBackup.Value);
            }
            if (Optional.IsDefined(NumberOfDisksAttachedToVm))
            {
                writer.WritePropertyName("numberOfDisksAttachedToVm"u8);
                writer.WriteNumberValue(NumberOfDisksAttachedToVm.Value);
            }
            if (Optional.IsCollectionDefined(IncludedDiskList))
            {
                writer.WritePropertyName("includedDiskList"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedDiskList))
            {
                writer.WritePropertyName("excludedDiskList"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        RecoveryPointDiskConfiguration IJsonModel<RecoveryPointDiskConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointDiskConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointDiskConfiguration(document.RootElement, options);
        }

        internal static RecoveryPointDiskConfiguration DeserializeRecoveryPointDiskConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> numberOfDisksIncludedInBackup = default;
            Optional<int> numberOfDisksAttachedToVm = default;
            Optional<IList<DiskInformation>> includedDiskList = default;
            Optional<IList<DiskInformation>> excludedDiskList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfDisksIncludedInBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfDisksIncludedInBackup = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfDisksAttachedToVm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfDisksAttachedToVm = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedDiskList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiskInformation> array = new List<DiskInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInformation.DeserializeDiskInformation(item, options));
                    }
                    includedDiskList = array;
                    continue;
                }
                if (property.NameEquals("excludedDiskList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiskInformation> array = new List<DiskInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInformation.DeserializeDiskInformation(item, options));
                    }
                    excludedDiskList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPointDiskConfiguration(Optional.ToNullable(numberOfDisksIncludedInBackup), Optional.ToNullable(numberOfDisksAttachedToVm), Optional.ToList(includedDiskList), Optional.ToList(excludedDiskList), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointDiskConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointDiskConfiguration)} does not support '{options.Format}' format.");
            }
        }

        RecoveryPointDiskConfiguration IPersistableModel<RecoveryPointDiskConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPointDiskConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointDiskConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPointDiskConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
