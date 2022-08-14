using eTickets.Data.BaseService;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
