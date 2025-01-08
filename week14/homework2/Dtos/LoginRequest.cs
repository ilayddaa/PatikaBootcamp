using System;
using System.ComponentModel.DataAnnotations;

namespace homework2.Dtos;

public class LoginRequest
{
    [Required]
    [EmailAddress] // email olup olmadığını kontrol eder.
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}