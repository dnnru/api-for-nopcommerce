using Nop.Core.Domain.Catalog;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.Products;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class ProductDtoMappings
    {
        public static ProductDto ToDto(this Product product)
        {
            return product.MapTo<Product, ProductDto>();
        }

        public static ProductAttributeValueDto ToDto(this ProductAttributeValue productAttributeValue)
        {
            return productAttributeValue.MapTo<ProductAttributeValue, ProductAttributeValueDto>();
        }

        public static ProductsForHomePageSliderToReturnDto ToDto(this ProductDto productDto)
        {
            return productDto.MapTo<ProductDto, ProductsForHomePageSliderToReturnDto>();
        }

        public static ProductsPriceToReturnDto ToDtoPrice(this Product product)
        {
            return product.MapTo<Product, ProductsPriceToReturnDto>();
        }

        public static ProductTopSellingToReturnDto ToDtoTopSelling(this ProductDto product)
        {
            return product.MapTo<ProductDto, ProductTopSellingToReturnDto>();
        }

        public static ProductsSearchTearmPriceCategoryToReturnDto ToDtoSearch(this ProductDto product)
        {
            return product.MapTo<ProductDto, ProductsSearchTearmPriceCategoryToReturnDto>();
        }
    }
}
