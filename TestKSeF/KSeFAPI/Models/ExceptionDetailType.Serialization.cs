// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KSeFAPI.Models
{
    public partial class ExceptionDetailType
    {
        internal static ExceptionDetailType DeserializeExceptionDetailType(JsonElement element)
        {
            int exceptionCode = default;
            string exceptionDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exceptionCode"))
                {
                    exceptionCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exceptionDescription"))
                {
                    exceptionDescription = property.Value.GetString();
                    continue;
                }
            }
            return new ExceptionDetailType(exceptionCode, exceptionDescription);
        }
    }
}
