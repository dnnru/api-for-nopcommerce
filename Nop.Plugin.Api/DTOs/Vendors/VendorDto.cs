using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nop.Plugin.Api.DTO.Base;

namespace Nop.Plugin.Api.DTOs.Vendors
{
    [JsonObject(Title = "vendor")]
    public class VendorDto:BaseDto
    {
        private ICollection<VendorNoteDto> _notes;
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        [JsonProperty("description")] 
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the picture identifier
        /// </summary>
        [JsonProperty("picture_id")] 
        public int PictureId { get; set; }

        /// <summary>
        /// Gets or sets the address identifier
        /// </summary>
        [JsonProperty("address_id")] 
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        [JsonProperty("admin_comment")]
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        [JsonProperty("deleted")] 
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        [JsonProperty("display_order")] 
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the meta keywords
        /// </summary>
        [JsonProperty("meta_keywords")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets the meta description
        /// </summary>
        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta title
        /// </summary>
        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets the page size
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers can select the page size
        /// </summary>
        [JsonProperty("allow_customers_to_select_page_size")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// Gets or sets the available customer selectable page size options
        /// </summary>
        [JsonProperty("page_size_options")]
        public string PageSizeOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the price range filtering is enabled
        /// </summary>
        [JsonProperty("price_range_filtering")]
        public bool PriceRangeFiltering { get; set; }

        /// <summary>
        /// Gets or sets the "from" price
        /// </summary>
        [JsonProperty("price_from")]
        public decimal PriceFrom { get; set; }

        /// <summary>
        /// Gets or sets the "to" price
        /// </summary>
        [JsonProperty("price_to")]
        public decimal PriceTo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the price range should be entered manually
        /// </summary>
        [JsonProperty("manually_price_range")]
        public bool ManuallyPriceRange { get; set; }

        public ICollection<VendorNoteDto> Notes
        {
            get
            {
                if (_notes == null)
                {
                    _notes = new List<VendorNoteDto>();
                }

                return _notes;
            }
            set
            {
                _notes = value;
            }
        }
    }
}
