﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nop.Plugin.Api.Infrastructure;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.ProductsParameters
{
    // JsonProperty is used only for swagger
    [ModelBinder(typeof(ParametersModelBinder<ProductsSearchParametersModel>))]
    public class ProductsSearchParametersModel : BaseProductsParametersModel
    {

        /// <summary>
        ///     list of product ids to include in response
        /// </summary>
        [JsonProperty("ids")]
        public List<int> Ids { get; set; }

        /// <summary>
        ///     Amount of results (default: 50) (maximum: 250)
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///     Page to show (default: 1)
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        ///     Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public int? SinceId { get; set; }

        /// <summary>
        ///     comma-separated list of fields to include in the response
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        ///     list of manufacturer part numbers that the resulted product must contain
        /// </summary>
        [JsonProperty("manufacturer_part_numbers")]
        public List<string> ManufacturerPartNumbers { get; set; }

        /// <summary>
        ///     filter for downloadable or non-downloadable products (products with or without shipment)
        /// </summary>
        [JsonProperty("is_download")]
        public bool? IsDownload { get; set; }


        /// <summary>
        ///     search tearm to search the products
        /// </summary>
        [JsonProperty("search_tearm")]
        public string SearchTearm { get; set; }

        /// <summary>
        ///     search the products via name
        /// </summary>
        [JsonProperty("search_name")]
        public bool SearchName { get; set; }

        /// <summary>
        ///     search the products via short description
        /// </summary>
        [JsonProperty("search_short_description")]
        public bool SearchShortDescription { get; set; }

        /// <summary>
        ///     search the products via full description
        /// </summary>
        [JsonProperty("search_full_description")]
        public bool SearchFullDescription { get; set; }
    }
}
