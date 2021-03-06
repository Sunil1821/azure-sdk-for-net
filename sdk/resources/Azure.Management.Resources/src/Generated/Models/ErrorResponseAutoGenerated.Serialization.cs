// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    internal partial class ErrorResponseAutoGenerated
    {
        internal static ErrorResponseAutoGenerated DeserializeErrorResponseAutoGenerated(JsonElement element)
        {
            string httpStatus = default;
            string errorCode = default;
            string errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new ErrorResponseAutoGenerated(httpStatus, errorCode, errorMessage);
        }
    }
}
