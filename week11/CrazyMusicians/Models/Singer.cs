using System;
using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models;

public class Singer
{
    [Required(ErrorMessage = "Id is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Id must be greater than 0!")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name must be less than 100 characters")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Genre is required")]
    [StringLength(100, ErrorMessage = "Genre must be less than 100 characters")]
    public string Genre { get; set; }

    [Required(ErrorMessage = "BestSong is required")]
    [StringLength(100, ErrorMessage = "BestSong must be less than 100 characters")]
    public string BestSong { get; set; }

    public Singer(int id, string name, string genre, string bestSong)
    {
        Id = id;
        Name = name;
        Genre = genre;
        BestSong = bestSong;
    }
}

