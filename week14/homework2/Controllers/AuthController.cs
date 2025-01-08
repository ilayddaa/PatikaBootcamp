using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using homework2.Data;
using homework2.Dtos;
using homework2.Migrations;
using homework2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace homework2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtDbContext _context;
    private readonly JwtSettings _jwtSettings;

    public AuthController(JwtDbContext context, IConfiguration config)
    {
        _context = context;
        _jwtSettings = config.GetSection("JwtSettings").Get<JwtSettings>();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var user = _context.Users.SingleOrDefault(u => u.Email == request.Email && u.Password == request.Password);
        if (user == null) return Unauthorized();

        var token = GenerateJwtToken(user);
        return Ok(new { Token = token });
    }

    private string GenerateJwtToken(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto registerDto)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var user = new User
        {
            Email = registerDto.Email,
            Password = registerDto.Password
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return Created();
    }

    [HttpGet("secret")] // kullanıcı eğer giriş yaptıysa bu route'a gelebilir.
    [Authorize] // Kullanıcının giriş yapıp yapmadığını kontrol eder kullanıcının geçerli bir tokeni varsa devam edebilir.
    public IActionResult GetSecret()
    {
        return Ok(new
        {
            EnBuyukRapci = "SagopaKajmer"
        });
    }

}

