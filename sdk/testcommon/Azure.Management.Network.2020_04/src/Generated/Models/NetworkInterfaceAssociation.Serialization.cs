// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkInterfaceAssociation
    {
        internal static NetworkInterfaceAssociation DeserializeNetworkInterfaceAssociation(JsonElement element)
        {
            string id = default;
            IReadOnlyList<SecurityRule> securityRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityRule> array = new List<SecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SecurityRule.DeserializeSecurityRule(item));
                        }
                    }
                    securityRules = array;
                    continue;
                }
            }
            return new NetworkInterfaceAssociation(id, securityRules);
        }
    }
}
