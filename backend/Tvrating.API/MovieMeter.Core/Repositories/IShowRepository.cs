﻿using MovieMeter.Core.Entities;

namespace MovieMeter.Core.Repositories;

public interface IShowRepository
{
    Task<List<Show>> GetAll();
    Task SaveShow(Show show);
    Task DeleteShow(Show show);
    Task EditShowRating(Show show, string rating);
    Task<Show?> GetById(int id);
}