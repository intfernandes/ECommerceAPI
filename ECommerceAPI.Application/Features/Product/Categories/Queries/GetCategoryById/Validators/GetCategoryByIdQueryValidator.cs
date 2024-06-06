﻿using ECommerceAPI.Application.Features.Product.Categories.Queries.GetCategoryById.Requests;
using FluentValidation;

namespace ECommerceAPI.Application.Features.Product.Categories.Queries.GetCategoryById.Validators
{
    public class GetCategoryByIdQueryValidator : AbstractValidator<GetCategoryByIdQueryRequest>
    {
        public GetCategoryByIdQueryValidator()
        {
            IdValidator();
        }

        public void IdValidator()
        {
            RuleFor(request => request.Id)
                .GreaterThan(0).WithMessage("Id must greater than 1.");
        }
    }
}