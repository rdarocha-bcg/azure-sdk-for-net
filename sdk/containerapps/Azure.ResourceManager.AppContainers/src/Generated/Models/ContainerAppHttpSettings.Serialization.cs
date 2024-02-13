// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppHttpSettings : IUtf8JsonSerializable, IJsonModel<ContainerAppHttpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppHttpSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppHttpSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RequireHttps))
            {
                writer.WritePropertyName("requireHttps"u8);
                writer.WriteBooleanValue(RequireHttps.Value);
            }
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(ForwardProxy))
            {
                writer.WritePropertyName("forwardProxy"u8);
                writer.WriteObjectValue(ForwardProxy);
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

        ContainerAppHttpSettings IJsonModel<ContainerAppHttpSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppHttpSettings(document.RootElement, options);
        }

        internal static ContainerAppHttpSettings DeserializeContainerAppHttpSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> requireHttps = default;
            Optional<HttpSettingsRoutes> routes = default;
            Optional<ContainerAppForwardProxy> forwardProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireHttps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireHttps = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = HttpSettingsRoutes.DeserializeHttpSettingsRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardProxy = ContainerAppForwardProxy.DeserializeContainerAppForwardProxy(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppHttpSettings(Optional.ToNullable(requireHttps), routes.Value, forwardProxy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppHttpSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppHttpSettings IPersistableModel<ContainerAppHttpSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppHttpSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppHttpSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
