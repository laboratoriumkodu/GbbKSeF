// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class InvoiceDivisionPlainPartType
    {
        internal static InvoiceDivisionPlainPartType DeserializeInvoiceDivisionPlainPartType(JsonElement element)
        {
            string partReferenceNumber = default;
            string partName = default;
            int partNumber = default;
            DateTimeOffset partRangeFrom = default;
            DateTimeOffset partRangeTo = default;
            DateTimeOffset partExpiration = default;
            FileUnlimitedHashType plainPartHash = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partReferenceNumber"))
                {
                    partReferenceNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partName"))
                {
                    partName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partNumber"))
                {
                    partNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partRangeFrom"))
                {
                    partRangeFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("partRangeTo"))
                {
                    partRangeTo = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("partExpiration"))
                {
                    partExpiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("plainPartHash"))
                {
                    plainPartHash = FileUnlimitedHashType.DeserializeFileUnlimitedHashType(property.Value);
                    continue;
                }
            }
            return new InvoiceDivisionPlainPartType(partReferenceNumber, partName, partNumber, partRangeFrom, partRangeTo, partExpiration, plainPartHash);
        }
    }
}
