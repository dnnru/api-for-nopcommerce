﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTOs.Vendors
{
    public class VendorsCountRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
