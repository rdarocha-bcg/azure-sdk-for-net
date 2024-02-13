// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    [PersistableModelProxy(typeof(UnknownRoleManagementPolicyRule))]
    public partial class RoleManagementPolicyRule : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleManagementPolicyRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target);
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

        RoleManagementPolicyRule IJsonModel<RoleManagementPolicyRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyRule(document.RootElement, options);
        }

        internal static RoleManagementPolicyRule DeserializeRoleManagementPolicyRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RoleManagementPolicyApprovalRule": return RoleManagementPolicyApprovalRule.DeserializeRoleManagementPolicyApprovalRule(element);
                    case "RoleManagementPolicyAuthenticationContextRule": return RoleManagementPolicyAuthenticationContextRule.DeserializeRoleManagementPolicyAuthenticationContextRule(element);
                    case "RoleManagementPolicyEnablementRule": return RoleManagementPolicyEnablementRule.DeserializeRoleManagementPolicyEnablementRule(element);
                    case "RoleManagementPolicyExpirationRule": return RoleManagementPolicyExpirationRule.DeserializeRoleManagementPolicyExpirationRule(element);
                    case "RoleManagementPolicyNotificationRule": return RoleManagementPolicyNotificationRule.DeserializeRoleManagementPolicyNotificationRule(element);
                }
            }
            return UnknownRoleManagementPolicyRule.DeserializeUnknownRoleManagementPolicyRule(element);
        }

        BinaryData IPersistableModel<RoleManagementPolicyRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyRule)} does not support '{options.Format}' format.");
            }
        }

        RoleManagementPolicyRule IPersistableModel<RoleManagementPolicyRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleManagementPolicyRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
