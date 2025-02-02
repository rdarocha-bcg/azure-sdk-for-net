// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MonitoringTarget : IUtf8JsonSerializable, IJsonModel<MonitoringTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringTarget>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringTarget)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentId))
            {
                if (DeploymentId != null)
                {
                    writer.WritePropertyName("deploymentId"u8);
                    writer.WriteStringValue(DeploymentId);
                }
                else
                {
                    writer.WriteNull("deploymentId");
                }
            }
            if (Optional.IsDefined(ModelId))
            {
                if (ModelId != null)
                {
                    writer.WritePropertyName("modelId"u8);
                    writer.WriteStringValue(ModelId);
                }
                else
                {
                    writer.WriteNull("modelId");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
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

        MonitoringTarget IJsonModel<MonitoringTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringTarget)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoringTarget(document.RootElement, options);
        }

        internal static MonitoringTarget DeserializeMonitoringTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deploymentId = default;
            string modelId = default;
            ModelTaskType taskType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deploymentId = null;
                        continue;
                    }
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelId = null;
                        continue;
                    }
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new ModelTaskType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitoringTarget(deploymentId, modelId, taskType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoringTarget>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringTarget)} does not support writing '{options.Format}' format.");
            }
        }

        MonitoringTarget IPersistableModel<MonitoringTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitoringTarget(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoringTarget)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
