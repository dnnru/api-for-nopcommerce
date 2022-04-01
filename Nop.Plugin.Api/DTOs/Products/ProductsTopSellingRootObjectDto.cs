using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Products
{
    public class ProductsTopSellingRootObjectDto : ISerializableObject
    {
        public ProductsTopSellingRootObjectDto()
        {
            Products = new List<ProductTopSellingToReturnDto>();
        }

        [JsonProperty("products")]
        public IList<ProductTopSellingToReturnDto> Products { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "products";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ProductTopSellingToReturnDto);
        }
    }
}
