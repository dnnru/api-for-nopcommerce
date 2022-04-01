using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nop.Plugin.Api.DTO;
using Nop.Plugin.Api.DTO.Customers;

namespace Nop.Plugin.Api.DTOs.Vendors
{
    public class VendorsRootObject : ISerializableObject
    {
        public VendorsRootObject()
        {
            Vendors = new List<VendorDto>();
        }

        [JsonProperty("vendors")]
        public IList<VendorDto> Vendors { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "vendors";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(VendorDto);
        }
    }
}
