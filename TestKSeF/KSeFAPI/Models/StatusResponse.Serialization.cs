// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class StatusResponse
    {
        internal static StatusResponse DeserializeStatusResponse(JsonElement element)
        {
            DateTimeOffset timestamp = default;
            string referenceNumber = default;
            int processingCode = default;
            string processingDescription = default;
            Optional</*Stream*/ string> upo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("referenceNumber"))
                {
                    referenceNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processingCode"))
                {
                    processingCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("processingDescription"))
                {
                    processingDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        //=============================== gbb: Removed
                        //property.ThrowNonNullablePropertyIsNull();
                        //===============================
                        continue;
                    }
                    upo = property.Value.GetString();
                    continue;
                }
            }
            return new StatusResponse(timestamp, referenceNumber, processingCode, processingDescription, upo.Value);
        }
    }
}
