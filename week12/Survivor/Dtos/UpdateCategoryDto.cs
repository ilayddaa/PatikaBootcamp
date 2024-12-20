using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos;

public class UpdateCategoryDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
    public string Name { get; set; }
}
