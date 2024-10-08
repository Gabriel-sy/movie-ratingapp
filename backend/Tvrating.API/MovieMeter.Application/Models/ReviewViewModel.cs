﻿using MovieMeter.Core.Entities;

namespace MovieMeter.Application.Models;

public class ReviewViewModel
{
    public ReviewViewModel(int id, int showId, string releaseDate, 
        List<string> genres, decimal userRating, string posterPath, 
        string overview, string directorName, string originalTitle, 
        string userReview, int likeAmount, List<string> likeNames,
        bool isLiked, string userName, byte[]? profilePicture
        , string? timeSinceCreation, DateTime? createdAt)
    {
        Id = id;
        ShowId = showId;
        ReleaseDate = releaseDate;
        Genres = genres;
        UserRating = userRating;
        PosterPath = posterPath;
        Overview = overview;
        DirectorName = directorName;
        OriginalTitle = originalTitle;
        UserReview = userReview;
        LikeAmount = likeAmount;
        LikeNames = likeNames;
        IsLiked = isLiked;
        UserName = userName;
        ProfilePicture = profilePicture ?? null;
        TimeSinceCreation = timeSinceCreation ?? null;
        CreatedAt = createdAt ?? null;
    }

    public int Id { get; set; }
    public int ShowId { get; set; }
    public string ReleaseDate { get; set; }
    public List<string> Genres { get; set; }
    public decimal UserRating { get; set; }
    public string PosterPath { get; set; }
    public string Overview { get; set; }
    public string? DirectorName { get; set; }
    public string OriginalTitle { get; set; }
    public string? UserReview { get; set; }
    public string? UserName { get; set; }
    public int LikeAmount { get; set; }
    public List<string> LikeNames { get; set; }
    public bool IsLiked { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public string? TimeSinceCreation { get; set; }
    public DateTime? CreatedAt { get; set; }

    public static ReviewViewModel FromEntity(Review review, string timeSinceCreation = "")
    {
        return new ReviewViewModel(review.Id, review.ShowId, review.ReleaseDate, review.Genres,
            review.UserRating, review.PosterPath, review.Overview, review.DirectorName, review.OriginalTitle
            , review.UserReview ?? "", review.LikeAmount, review.LikeNames, review.IsLiked, review.User.Name,
            review.User.ProfilePicture, timeSinceCreation, review.CreatedAt);
    }
}