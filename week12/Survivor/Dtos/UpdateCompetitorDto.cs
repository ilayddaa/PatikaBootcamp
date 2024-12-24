using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos;

public class UpdateCompetitorDto
{
    [Required(ErrorMessage = "Lütfen geçerli bir Yarışması Id'si giriniz!")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
    public string FirstName { get; set; }


    [Required(ErrorMessage = "Lütfen soyisminizi giriniz!")]
    public string LastName { get; set; }
}
