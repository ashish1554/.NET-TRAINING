using AutoMapper;
using DAY1.Data;
using DAY1.DTO;
using DAY1.Interfaces;
using DAY1.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DAY1.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthService(AppDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<string> LoginUser(LoginDto user)
        {
            var getUser = _context.Users.FirstOrDefault(e => e.Email == user.Email);
            if (getUser is null)
            {
                return null;
            }
            if (new PasswordHasher<User>().VerifyHashedPassword(getUser, getUser.HashedPassword, user.Password) == PasswordVerificationResult.Failed)
            {
                return null;
            }
            return TokenGeneration(getUser);
        }

        private string TokenGeneration(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role,user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenDescription = new JwtSecurityToken(
                 issuer: _configuration["Jwt:Issuer"],
                 audience: _configuration["Jwt:Audience"],
                 claims: claims,
                 expires: DateTime.UtcNow.AddDays(1),
                 signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescription);
        }
        public async Task<User?> RegisterUser(UserDto user)
        {
            if (await _context.Users.AnyAsync(e => e.Email == user.Email))
            {
                return null;
            }
            var newUser = new User();
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.Role = user.Role;
            newUser.HashedPassword = new PasswordHasher<User>().HashPassword(newUser, user.Password);

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            //var userDto = _mapper.Map<UserDto>(newUser);
            //userDto.Password = user.Password;

            return newUser;

        }
    }
}
