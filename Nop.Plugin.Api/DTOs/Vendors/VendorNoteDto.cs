using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nop.Core.Domain.Vendors;
using Nop.Plugin.Api.DTO.Base;

namespace Nop.Plugin.Api.DTOs.Vendors
{
    public class VendorNoteDto:BaseDto
    {
        /// <summary>
        /// Gets or sets the vendor identifier
        /// </summary>
        [JsonProperty("vendor_id")]
        public int VendorId { get; set; }

        /// <summary>
        /// Gets or sets the note
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the date and time of vendor note creation
        /// </summary>
        [JsonProperty("created_on_utc")]
        public DateTime CreatedOnUtc { get; set; }
    }
}
