// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.AI.Translation.Document
{
    public partial class DocumentStatusResult
    {
        internal static DocumentStatusResult DeserializeDocumentStatusResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri path = default;
            Uri sourcePath = default;
            DateTimeOffset createdDateTimeUtc = default;
            DateTimeOffset lastActionDateTimeUtc = default;
            DocumentTranslationStatus status = default;
            string to = default;
            JsonElement error = default;
            float progress = default;
            string id = default;
            long characterCharged = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    path = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePath"u8))
                {
                    sourcePath = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTimeUtc"u8))
                {
                    createdDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTimeUtc"u8))
                {
                    lastActionDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new DocumentTranslationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("progress"u8))
                {
                    progress = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("characterCharged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    characterCharged = property.Value.GetInt64();
                    continue;
                }
            }
            return new DocumentStatusResult(
                path,
                sourcePath,
                createdDateTimeUtc,
                lastActionDateTimeUtc,
                status,
                to,
                error,
                progress,
                id,
                characterCharged);
        }
    }
}
