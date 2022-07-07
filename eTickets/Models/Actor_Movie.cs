using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        // Relationships
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
