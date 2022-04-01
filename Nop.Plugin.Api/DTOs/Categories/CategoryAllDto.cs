using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Nop.Plugin.Api.DTO.Base;
using Nop.Plugin.Api.DTO.Images;
using Nop.Plugin.Api.DTO.Languages;

namespace Nop.Plugin.Api.DTO.Categories
{
    //[Validator(typeof(CategoryDtoValidator))]
    [JsonObject(Title = "category")]
    public class CategoryAllDto : BaseDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        
        /// <summary>
        ///     Gets or sets the parent category identifier
        /// </summary>
        [JsonProperty("parent_category_id")]
        public int? ParentCategoryId { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to show the category on home page
        /// </summary>
        [JsonProperty("show_on_home_page")]
        public bool? ShowOnHomePage { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to include this category in the top menu
        /// </summary>
        [JsonProperty("include_in_top_menu")]
        public bool? IncludeInTopMenu { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the entity is published
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        ///     Gets or sets the display order
        /// </summary>
        [JsonProperty("display_order")]
        public int? DisplayOrder { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }
    }
}
