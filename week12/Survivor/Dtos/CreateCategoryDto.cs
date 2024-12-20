using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
    public string Name { get; set; }
}
