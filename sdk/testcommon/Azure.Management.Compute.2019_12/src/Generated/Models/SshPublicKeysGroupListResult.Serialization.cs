// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class SshPublicKeysGroupListResult
    {
        internal static SshPublicKeysGroupListResult DeserializeSshPublicKeysGroupListResult(JsonElement element)
        {
            IReadOnlyList<SshPublicKeyResource> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SshPublicKeyResource> array = new List<SshPublicKeyResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SshPublicKeyResource.DeserializeSshPublicKeyResource(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SshPublicKeysGroupListResult(value, nextLink);
        }
    }
}
