using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Nop.Core.Domain.Vendors;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTOs.Vendors;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class VendorNoteDtoMappings
    {
        public static VendorNoteDto ToDto(this VendorNote vendorNote)
        {
            return vendorNote.MapTo<VendorNote, VendorNoteDto>();
        }

        public static VendorNote ToEntity(this VendorNoteDto vendorNoteDto)
        {
            return vendorNoteDto.MapTo<VendorNoteDto,VendorNote>();

        }
    }
}
