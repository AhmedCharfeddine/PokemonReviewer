namespace PokemonReviewer.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gym { get; set; }
        public Country Country { get; set; }

        // many2many with Pokemon
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}