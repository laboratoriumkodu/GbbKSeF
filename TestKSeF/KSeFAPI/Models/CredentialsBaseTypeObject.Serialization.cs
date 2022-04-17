// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class CredentialsBaseTypeObject
    {
        internal static CredentialsBaseTypeObject DeserializeCredentialsBaseTypeObject(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "list_token": return CredentialsTokenType.DeserializeCredentialsTokenType(element);
                    case "single_parent": return CredentialsParentType.DeserializeCredentialsParentType(element);
                }
            }
            Optional<object> identifier = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identifier = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new CredentialsBaseTypeObject(identifier.Value, type);
        }
    }
}
