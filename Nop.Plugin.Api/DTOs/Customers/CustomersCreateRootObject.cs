using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Customers
{
    public class CustomersCreateRootObject : ISerializableObject
    {
        public CustomersCreateRootObject()
        {
            Customers = new List<CustomerCreateDto>();
        }

        [JsonProperty("customers")]
        public IList<CustomerCreateDto> Customers { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "customers";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(CustomerCreateDto);
        }
    }
}
