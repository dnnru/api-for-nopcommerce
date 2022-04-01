using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Products
{
    public class ProductsPriceRootObjectDto : ISerializableObject
    {
        public ProductsPriceRootObjectDto()
        {
            Products = new List<ProductsPriceToReturnDto>();
        }

        [JsonProperty("products")]
        public IList<ProductsPriceToReturnDto> Products { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "products";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(ProductsForHomePageSliderToReturnDto);
        }
    }
}
