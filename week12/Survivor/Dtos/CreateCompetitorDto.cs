using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos;

public class CreateCompetitorDto
{
    [Required(ErrorMessage = "Lütfen Kategori için Id giriniz!")]
    [Range(0, int.MaxValue, ErrorMessage = "Lütfen geçerli bir Id giriniz.")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
    public string FirstName { get; set; }


    [Required(ErrorMessage = "Lütfen soyisminizi giriniz!")]
    public string LastName { get; set; }
}
