// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class RunCommandDocument
    {
        internal static RunCommandDocument DeserializeRunCommandDocument(JsonElement element)
        {
            IReadOnlyList<string> script = default;
            IReadOnlyList<RunCommandParameterDefinition> parameters = default;
            string schema = default;
            string id = default;
            OperatingSystemTypes osType = default;
            string label = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("script"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    script = array;
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RunCommandParameterDefinition> array = new List<RunCommandParameterDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(RunCommandParameterDefinition.DeserializeRunCommandParameterDefinition(item));
                        }
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("$schema"))
                {
                    schema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString().ToOperatingSystemTypes();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new RunCommandDocument(schema, id, osType, label, description, script, parameters);
        }
    }
}
