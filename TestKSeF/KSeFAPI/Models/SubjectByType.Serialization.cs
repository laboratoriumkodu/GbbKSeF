// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class SubjectByType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("issuedByIdentifier");
            writer.WriteObjectValue(IssuedByIdentifier);
            writer.WritePropertyName("issuedByName");
            writer.WriteObjectValue(IssuedByName);
            writer.WriteEndObject();
        }

        internal static SubjectByType DeserializeSubjectByType(JsonElement element)
        {
            SubjectIdentifierByType issuedByIdentifier = default;
            SubjectNameType issuedByName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issuedByIdentifier"))
                {
                    issuedByIdentifier = SubjectIdentifierByType.DeserializeSubjectIdentifierByType(property.Value);
                    continue;
                }
                if (property.NameEquals("issuedByName"))
                {
                    issuedByName = SubjectNameType.DeserializeSubjectNameType(property.Value);
                    continue;
                }
            }
            return new SubjectByType(issuedByIdentifier, issuedByName);
        }
    }
}
