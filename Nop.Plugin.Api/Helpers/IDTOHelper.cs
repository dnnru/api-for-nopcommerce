﻿using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Stores;
using Nop.Core.Domain.Topics;
using Nop.Plugin.Api.DTO;
using Nop.Plugin.Api.DTO.Categories;
using Nop.Plugin.Api.DTO.Languages;
using Nop.Plugin.Api.DTO.Manufacturers;
using Nop.Plugin.Api.DTO.OrderItems;
using Nop.Plugin.Api.DTO.Orders;
using Nop.Plugin.Api.DTO.ProductAttributes;
using Nop.Plugin.Api.DTO.Products;
using Nop.Plugin.Api.DTO.ShoppingCarts;
using Nop.Plugin.Api.DTO.SpecificationAttributes;
using Nop.Plugin.Api.DTO.Stores;
using Nop.Plugin.Api.DTOs.Topics;
using System.Collections.Generic;

namespace Nop.Plugin.Api.Helpers
{
    public interface IDTOHelper
    {
        Task<ProductDto> PrepareProductDTOAsync(Product product);
        Task<CategoryDto> PrepareCategoryDTOAsync(Category category);
        Task<CategoryAllDto> PrepareAllCategoryDTOAsync(Category category);
        Task<OrderDto> PrepareOrderDTOAsync(Order order);
        Task<OrderSimpleDto> PrepareOrderSimpleDTOAsync(Order order);
        Task<ShoppingCartItemDto> PrepareShoppingCartItemDTOAsync(ShoppingCartItem shoppingCartItem);
        Task<OrderItemDto> PrepareOrderItemDTOAsync(OrderItem orderItem);
        Task<StoreDto> PrepareStoreDTOAsync(Store store);
        Task<LanguageDto> PrepareLanguageDtoAsync(Language language);
        Task<CurrencyDto> PrepareCurrencyDtoAsync(Currency currency);
        ProductAttributeDto PrepareProductAttributeDTO(ProductAttribute productAttribute);
        ProductSpecificationAttributeDto PrepareProductSpecificationAttributeDto(ProductSpecificationAttribute productSpecificationAttribute);
        SpecificationAttributeDto PrepareSpecificationAttributeDto(SpecificationAttribute specificationAttribute);
        Task<ManufacturerDto> PrepareManufacturerDtoAsync(Manufacturer manufacturer);
        TopicDto PrepareTopicDTO(Topic topic);
        Task<ProductsForHomePageSliderToReturnDto> PrepareProductForHomePageSliderToReturnDTOAsync(Product product);
        Task<ProductsSearchTearmPriceCategoryToReturnDto> PrepareProductForSearchTearmPriceCategoryToReturnDTOAsync(Product product);
        ProductsPriceToReturnDto PrepareProductPriceToReturnDTOAsync(Product product);
        Task<ProductTopSellingToReturnDto> PrepareProductsTopSellingToReturnDTOAsync(Product product, Dictionary<int,int> productCount);
    }
}