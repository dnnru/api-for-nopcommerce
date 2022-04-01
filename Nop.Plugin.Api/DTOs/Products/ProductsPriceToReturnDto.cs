using System.Collections.Generic;
using Newtonsoft.Json;
using Nop.Plugin.Api.Attributes;
using Nop.Plugin.Api.DTO.Base;
using Nop.Plugin.Api.DTO.Images;

namespace Nop.Plugin.Api.DTO.Products
{
    [JsonObject(Title = "product")]
    //[Validator(typeof(ProductDtoValidator))]
    public class ProductsPriceToReturnDto : BaseDto
    {
        private int? _productTypeId;

        /// <summary>
        ///     Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }
    }
}
