using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Vendors;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTOs.Vendors;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class VendorDtoMappings
    {
        public static VendorDto ToDto(this Vendor vendor)
        {
            return vendor.MapTo<Vendor, VendorDto>();
        }
    }
}
