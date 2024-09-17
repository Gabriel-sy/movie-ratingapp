﻿using MovieMeter.Core.Entities;
using MovieMeter.Core.Services;

namespace MovieMeter.Application.Models;

public class CreateShowInputModel
{
    public int ShowId { get; set; }
    public string Title { get; set; }
    public string? ReleaseDate { get; set; }
    public int[] Genres { get; set; }
    public string UserRating { get; set; }
    public decimal PublicRating { get; set; }
    public string MediaType { get; set; }
    public string PosterPath { get; set; }
    public string Overview { get; set; }
    public string? DirectorName { get; set; }

    public Show FromEntity()
    {
        ReleaseDate = ReleaseDate?[..4];
        
        return new Show(ShowId, Title, ReleaseDate, ConvertGenre.Convert(Genres), UserRating
                ,PublicRating, MediaType, PosterPath, Overview, DirectorName);
        
    }
}