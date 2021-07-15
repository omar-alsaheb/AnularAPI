using AngularAPI.DTOs;
using AngularAPI.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                return Unauthorized();
            }
            var result = await signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);
            return new UserDTO
            {
                Email = user.Email,
                DisplayName = user.UserName,
                Token = "Token"
            };
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
        {
            var user = new ApplicationUser
            {

                Email = registerDTO.Email,
                UserName = registerDTO.Email,
                DisplayName = registerDTO.UserName

            };
            var result = await userManager.CreateAsync(user, registerDTO.Password);
            if (!result.Succeeded) return BadRequest();

            return new UserDTO
            {
                Email = user.Email,
                DisplayName = user.DisplayName,
                Token = "Token"
            };
        }
    }
}
