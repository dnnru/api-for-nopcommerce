using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Products
{
    public class ProductsSearchTearmPriceCategoryRootObjectDto : ISerializableObject
    {
        public ProductsSearchTearmPriceCategoryRootObjectDto()
        {
            Products = new List<ProductsSearchTearmPriceCategoryToReturnDto>();
        }

        [JsonProperty("products")]
        public IList<ProductsSearchTearmPriceCategoryToReturnDto> Products { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "products";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ProductsSearchTearmPriceCategoryToReturnDto);
        }
    }
}
