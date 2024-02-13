// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    [PersistableModelProxy(typeof(UnknownDeliveryRuleCondition))]
    public partial class DeliveryRuleCondition : IUtf8JsonSerializable, IJsonModel<DeliveryRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeliveryRuleCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeliveryRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
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

        DeliveryRuleCondition IJsonModel<DeliveryRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeliveryRuleCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleCondition(document.RootElement, options);
        }

        internal static DeliveryRuleCondition DeserializeDeliveryRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("name", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ClientPort": return DeliveryRuleClientPortCondition.DeserializeDeliveryRuleClientPortCondition(element);
                    case "Cookies": return DeliveryRuleCookiesCondition.DeserializeDeliveryRuleCookiesCondition(element);
                    case "HostName": return DeliveryRuleHostNameCondition.DeserializeDeliveryRuleHostNameCondition(element);
                    case "HttpVersion": return DeliveryRuleHttpVersionCondition.DeserializeDeliveryRuleHttpVersionCondition(element);
                    case "IsDevice": return DeliveryRuleIsDeviceCondition.DeserializeDeliveryRuleIsDeviceCondition(element);
                    case "PostArgs": return DeliveryRulePostArgsCondition.DeserializeDeliveryRulePostArgsCondition(element);
                    case "QueryString": return DeliveryRuleQueryStringCondition.DeserializeDeliveryRuleQueryStringCondition(element);
                    case "RemoteAddress": return DeliveryRuleRemoteAddressCondition.DeserializeDeliveryRuleRemoteAddressCondition(element);
                    case "RequestBody": return DeliveryRuleRequestBodyCondition.DeserializeDeliveryRuleRequestBodyCondition(element);
                    case "RequestHeader": return DeliveryRuleRequestHeaderCondition.DeserializeDeliveryRuleRequestHeaderCondition(element);
                    case "RequestMethod": return DeliveryRuleRequestMethodCondition.DeserializeDeliveryRuleRequestMethodCondition(element);
                    case "RequestScheme": return DeliveryRuleRequestSchemeCondition.DeserializeDeliveryRuleRequestSchemeCondition(element);
                    case "RequestUri": return DeliveryRuleRequestUriCondition.DeserializeDeliveryRuleRequestUriCondition(element);
                    case "ServerPort": return DeliveryRuleServerPortCondition.DeserializeDeliveryRuleServerPortCondition(element);
                    case "SocketAddr": return DeliveryRuleSocketAddressCondition.DeserializeDeliveryRuleSocketAddressCondition(element);
                    case "SslProtocol": return DeliveryRuleSslProtocolCondition.DeserializeDeliveryRuleSslProtocolCondition(element);
                    case "UrlFileExtension": return DeliveryRuleUriFileExtensionCondition.DeserializeDeliveryRuleUriFileExtensionCondition(element);
                    case "UrlFileName": return DeliveryRuleUriFileNameCondition.DeserializeDeliveryRuleUriFileNameCondition(element);
                    case "UrlPath": return DeliveryRuleUriPathCondition.DeserializeDeliveryRuleUriPathCondition(element);
                }
            }
            return UnknownDeliveryRuleCondition.DeserializeUnknownDeliveryRuleCondition(element);
        }

        BinaryData IPersistableModel<DeliveryRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        DeliveryRuleCondition IPersistableModel<DeliveryRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeliveryRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeliveryRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeliveryRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeliveryRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
