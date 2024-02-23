// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class KubernetesSourceControlConfigurationData : IUtf8JsonSerializable, IJsonModel<KubernetesSourceControlConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesSourceControlConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesSourceControlConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesSourceControlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesSourceControlConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OperatorNamespace))
            {
                writer.WritePropertyName("operatorNamespace"u8);
                writer.WriteStringValue(OperatorNamespace);
            }
            if (Optional.IsDefined(OperatorInstanceName))
            {
                writer.WritePropertyName("operatorInstanceName"u8);
                writer.WriteStringValue(OperatorInstanceName);
            }
            if (Optional.IsDefined(OperatorType))
            {
                writer.WritePropertyName("operatorType"u8);
                writer.WriteStringValue(OperatorType.Value.ToString());
            }
            if (Optional.IsDefined(OperatorParams))
            {
                writer.WritePropertyName("operatorParams"u8);
                writer.WriteStringValue(OperatorParams);
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                writer.WritePropertyName("configurationProtectedSettings"u8);
                writer.WriteStartObject();
                foreach (var item in ConfigurationProtectedSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(OperatorScope))
            {
                writer.WritePropertyName("operatorScope"u8);
                writer.WriteStringValue(OperatorScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RepositoryPublicKey))
            {
                writer.WritePropertyName("repositoryPublicKey"u8);
                writer.WriteStringValue(RepositoryPublicKey);
            }
            if (Optional.IsDefined(SshKnownHostsContents))
            {
                writer.WritePropertyName("sshKnownHostsContents"u8);
                writer.WriteStringValue(SshKnownHostsContents);
            }
            if (Optional.IsDefined(IsHelmOperatorEnabled))
            {
                writer.WritePropertyName("enableHelmOperator"u8);
                writer.WriteBooleanValue(IsHelmOperatorEnabled.Value);
            }
            if (Optional.IsDefined(HelmOperatorProperties))
            {
                writer.WritePropertyName("helmOperatorProperties"u8);
                writer.WriteObjectValue(HelmOperatorProperties);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ComplianceStatus))
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteObjectValue(ComplianceStatus);
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

        KubernetesSourceControlConfigurationData IJsonModel<KubernetesSourceControlConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesSourceControlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesSourceControlConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesSourceControlConfigurationData(document.RootElement, options);
        }

        internal static KubernetesSourceControlConfigurationData DeserializeKubernetesSourceControlConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> repositoryUrl = default;
            Optional<string> operatorNamespace = default;
            Optional<string> operatorInstanceName = default;
            Optional<KubernetesOperator> operatorType = default;
            Optional<string> operatorParams = default;
            Optional<IDictionary<string, string>> configurationProtectedSettings = default;
            Optional<KubernetesOperatorScope> operatorScope = default;
            Optional<string> repositoryPublicKey = default;
            Optional<string> sshKnownHostsContents = default;
            Optional<bool> enableHelmOperator = default;
            Optional<HelmOperatorProperties> helmOperatorProperties = default;
            Optional<KubernetesConfigurationProvisioningStateType> provisioningState = default;
            Optional<KubernetesConfigurationComplianceStatus> complianceStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("repositoryUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("operatorNamespace"u8))
                        {
                            operatorNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatorInstanceName"u8))
                        {
                            operatorInstanceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatorType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operatorType = new KubernetesOperator(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("operatorParams"u8))
                        {
                            operatorParams = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationProtectedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationProtectedSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("operatorScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operatorScope = new KubernetesOperatorScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("repositoryPublicKey"u8))
                        {
                            repositoryPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshKnownHostsContents"u8))
                        {
                            sshKnownHostsContents = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableHelmOperator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHelmOperator = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("helmOperatorProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            helmOperatorProperties = HelmOperatorProperties.DeserializeHelmOperatorProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KubernetesConfigurationProvisioningStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("complianceStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            complianceStatus = KubernetesConfigurationComplianceStatus.DeserializeKubernetesConfigurationComplianceStatus(property0.Value, options);
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
            return new KubernetesSourceControlConfigurationData(id, name, type, systemData.Value, repositoryUrl.Value, operatorNamespace.Value, operatorInstanceName.Value, Optional.ToNullable(operatorType), operatorParams.Value, Optional.ToDictionary(configurationProtectedSettings), Optional.ToNullable(operatorScope), repositoryPublicKey.Value, sshKnownHostsContents.Value, Optional.ToNullable(enableHelmOperator), helmOperatorProperties.Value, Optional.ToNullable(provisioningState), complianceStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesSourceControlConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesSourceControlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesSourceControlConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        KubernetesSourceControlConfigurationData IPersistableModel<KubernetesSourceControlConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesSourceControlConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesSourceControlConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesSourceControlConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesSourceControlConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
