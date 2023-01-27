namespace eTickets.Models
{
    public class Actor_Movie
    {
        //Actor and Movie many to many
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
