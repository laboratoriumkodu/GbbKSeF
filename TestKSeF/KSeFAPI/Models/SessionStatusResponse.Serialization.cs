// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class SessionStatusResponse
    {
        internal static SessionStatusResponse DeserializeSessionStatusResponse(JsonElement element)
        {
            DateTimeOffset timestamp = default;
            string referenceNumber = default;
            long numberOfElements = default;
            int pageSize = default;
            int pageOffset = default;
            int processingCode = default;
            string processingDescription = default;
            IReadOnlyList<SessionInvoiceStatusType> invoiceStatusList = default;
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
                if (property.NameEquals("numberOfElements"))
                {
                    numberOfElements = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("pageSize"))
                {
                    pageSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pageOffset"))
                {
                    pageOffset = property.Value.GetInt32();
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
                if (property.NameEquals("invoiceStatusList"))
                {
                    List<SessionInvoiceStatusType> array = new List<SessionInvoiceStatusType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SessionInvoiceStatusType.DeserializeSessionInvoiceStatusType(item));
                    }
                    invoiceStatusList = array;
                    continue;
                }
            }
            return new SessionStatusResponse(timestamp, referenceNumber, numberOfElements, pageSize, pageOffset, processingCode, processingDescription, invoiceStatusList);
        }
    }
}
