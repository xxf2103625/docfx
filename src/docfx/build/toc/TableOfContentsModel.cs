// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Docs.Build
{
    public class TableOfContentsModel
    {
        [JsonProperty(PropertyName = "metadata")]
        public TableOfContentsMetadata Metadata { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<TableOfContentsItem> Items { get; set; }
    }
}
