using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Vendors;
using Nop.Plugin.Api.Authorization.Attributes;
using Nop.Plugin.Api.DTO.Errors;
using Nop.Plugin.Api.DTOs.Vendors;
using Nop.Plugin.Api.Factories;
using Nop.Plugin.Api.JSON.Serializers;
using Nop.Plugin.Api.ModelBinders;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Media;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Services.Vendors;
using Nop.Plugin.Api.Delta;
using Nop.Plugin.Api.JSON.ActionResults;
using Nop.Plugin.Api.MappingExtensions;

namespace Nop.Plugin.Api.Controllers
{
    [AuthorizePermission("ManageVendors")]
    public class VendorsController:BaseApiController
    {
        private readonly IVendorService _vendorService;
        private readonly IFactory<Vendor> _factory;
        public VendorsController(IFactory<Vendor> factory ,IVendorService vendorService, IJsonFieldsSerializer jsonFieldsSerializer, IAclService aclService, ICustomerService customerService, IStoreMappingService storeMappingService, IStoreService storeService, IDiscountService discountService, ICustomerActivityService customerActivityService, ILocalizationService localizationService, IPictureService pictureService) : base(jsonFieldsSerializer, aclService, customerService, storeMappingService, storeService, discountService, customerActivityService, localizationService, pictureService)
        {
            _vendorService = vendorService;
            _factory = factory;
        }

        [HttpPost]
        [Route("/api/vendors", Name = "CreateVendor")]
        [ProducesResponseType(typeof(VendorsRootObject), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorsRootObject), 422)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> CreateVendor(
            [FromBody] [ModelBinder(typeof(JsonModelBinder<VendorDto>))]
            Delta<VendorDto> vendorDelta)
        {
            // Here we display the errors if the validation has failed at some point.
            if (!ModelState.IsValid)
            {
                return Error();
            }

            //If the validation has passed the customerDelta object won't be null for sure so we don't need to check for this.

            // Inserting the new vendor
            var newVendor = await _factory.InitializeAsync();
            vendorDelta.Merge(newVendor);
            await _vendorService.InsertVendorAsync(newVendor);
            var newVendorDto = newVendor.ToDto();
            if (vendorDelta.Dto.Notes != null)
            {
                foreach (var vendorNoteDto in vendorDelta.Dto.Notes)
                {
                    var newNote = vendorNoteDto.ToEntity();
                    await _vendorService.InsertVendorNoteAsync(newNote);
                    newVendorDto.Notes.Add(newNote.ToDto());
                }
            }
            //activity log
            await CustomerActivityService.InsertActivityAsync("AddNewVendor", await LocalizationService.GetResourceAsync("ActivityLog.AddNewVendor"), newVendor);

            var vendorsRootObject = new VendorsRootObject();
            vendorsRootObject.Vendors.Add(newVendorDto);

            var json = JsonFieldsSerializer.Serialize(vendorsRootObject, string.Empty);

            return new RawJsonActionResult(json);
        }
    }
}
