﻿namespace ECommerceAPI.Application.Features.Product.Categories.Queries.GetAllCategories.DTOs
{
    public class GetAllCategoriesQueryDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ParentCategory { get; set; }
        public string? Description { get; set; }
    }
}