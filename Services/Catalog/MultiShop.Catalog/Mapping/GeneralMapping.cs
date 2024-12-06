using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();
        }
    }
}