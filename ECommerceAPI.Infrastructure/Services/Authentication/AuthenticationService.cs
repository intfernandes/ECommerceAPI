﻿using ECommerceAPI.Application.DTOs.Authentication;
using ECommerceAPI.Application.Interfaces.Services.Authentication;
using ECommerceAPI.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace ECommerceAPI.Infrastructure.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AuthenticationService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public Task<AuthanticationResponseDTO> SignInAsync(SignInDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<AuthanticationResponseDTO> SignUpAsync(SignUpDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}