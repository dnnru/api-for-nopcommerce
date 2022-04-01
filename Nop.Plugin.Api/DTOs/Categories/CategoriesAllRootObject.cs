using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Categories
{
    public class CategoriesAllRootObject : ISerializableObject
    {
        public CategoriesAllRootObject()
        {
            Categories = new List<CategoryAllDto>();
        }

        [JsonProperty("categories")]
        public IList<CategoryAllDto> Categories { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "categories";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(CategoryAllDto);
        }
    }
}
