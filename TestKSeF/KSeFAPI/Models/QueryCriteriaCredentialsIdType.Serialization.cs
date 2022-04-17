// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class QueryCriteriaCredentialsIdType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("queryCredentialsTypeResultType");
            writer.WriteStringValue(QueryCredentialsTypeResultType.ToString());
            writer.WritePropertyName("queryCredentialsScopeResultType");
            writer.WriteStringValue(QueryCredentialsScopeResultType.ToString());
            writer.WritePropertyName("credentialsIdentifier");
            writer.WriteObjectValue(CredentialsIdentifier);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }
    }
}
