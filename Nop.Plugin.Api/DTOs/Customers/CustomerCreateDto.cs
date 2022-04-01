using System.Collections.Generic;
using Newtonsoft.Json;
using Nop.Plugin.Api.Attributes;
using Nop.Plugin.Api.DTO.ShoppingCarts;

namespace Nop.Plugin.Api.DTO.Customers
{
    [JsonObject(Title = "customer")]
    //[Validator(typeof(CustomerCreateDtoValidator))]
    public class CustomerCreateDto : BaseCustomerDto
    {
        [JsonIgnore]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
