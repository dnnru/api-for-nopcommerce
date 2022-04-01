using System.Collections.Generic;
using Newtonsoft.Json;
using Nop.Plugin.Api.Attributes;
using Nop.Plugin.Api.DTO.Base;
using Nop.Plugin.Api.DTO.Images;

namespace Nop.Plugin.Api.DTO.Products
{
    [JsonObject(Title = "product")]
    //[Validator(typeof(ProductDtoValidator))]
    public class ProductsSearchTearmPriceCategoryToReturnDto : BaseDto
    {
        private int? _productTypeId;

        /// <summary>
        ///     Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the short description
        /// </summary>
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        ///     Gets or sets the full description
        /// </summary>
        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to show the product on home page
        /// </summary>
        [JsonProperty("show_on_home_page")]
        public bool? ShowOnHomepage { get; set; }


        /// <summary>
        ///     Gets or sets the price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        ///     Gets or sets the old price
        /// </summary>
        [JsonProperty("old_price")]
        public decimal? OldPrice { get; set; }

        /// <summary>
        ///     Gets or sets the product cost
        /// </summary>
        [JsonProperty("product_cost")]
        public decimal? ProductCost { get; set; }

        /// <summary>
        ///     Gets or sets the product special price
        /// </summary>
        [JsonProperty("special_price")]
        public decimal? SpecialPrice { get; set; }

        /// <summary>
        ///     Gets or sets a display order.
        ///     This value is used when sorting associated products (used with "grouped" products)
        ///     This value is used when sorting home page products
        /// </summary>
        [JsonProperty("display_order")]
        public int? DisplayOrder { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the entity is published
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }


        [ImageCollectionValidation]
        [JsonProperty("images")]
        public List<ImageMappingDto> Images { get; set; }

        [JsonProperty("attributes")]
        public List<ProductAttributeMappingDto> ProductAttributeMappings { get; set; }
    }
}
