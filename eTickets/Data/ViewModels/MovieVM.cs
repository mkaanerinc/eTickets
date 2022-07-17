using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Movie description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in $")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie Poster Url is required")]
        [Display(Name = "Movie poster Url")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Movie start date is required")]
        [Display(Name = "Movie start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Movie end date is required")]
        [Display(Name = "Movie end date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie category is required")]
        [Display(Name = "Select Category")]
        public MovieCategory MovieCategory { get; set; }

        [Required(ErrorMessage = "Movie actor(s) is required")]
        [Display(Name = "Select actor(s)")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Movie cinema is required")]
        [Display(Name = "Select a cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Movie producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }
    }
}
