using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Products
{
    public class ProductsForHomePageSliderRootObjectDto : ISerializableObject
    {
        public ProductsForHomePageSliderRootObjectDto()
        {
            Products = new List<ProductsForHomePageSliderToReturnDto>();
        }

        [JsonProperty("products")]
        public IList<ProductsForHomePageSliderToReturnDto> Products { get; set; }

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
