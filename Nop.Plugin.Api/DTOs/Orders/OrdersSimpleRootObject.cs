using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Orders
{
    public class OrdersSimpleRootObject : ISerializableObject
    {
        public OrdersSimpleRootObject()
        {
            Orders = new List<OrderSimpleDto>();
        }

        [JsonProperty("orders")]
        public IList<OrderSimpleDto> Orders { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "orders";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(OrderSimpleDto);
        }
    }
}
