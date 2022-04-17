// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class QueryCriteriaInvoiceRangeType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("invoicingDateFrom");
            writer.WriteStringValue(InvoicingDateFrom, "O");
            writer.WritePropertyName("invoicingDateTo");
            writer.WriteStringValue(InvoicingDateTo, "O");
            writer.WritePropertyName("subjectType");
            writer.WriteStringValue(SubjectType.ToString());
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }
    }
}
