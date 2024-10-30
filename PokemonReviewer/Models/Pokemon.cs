namespace PokemonReviewer.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }

        // many2many with Owner
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        
        // many2many with Category
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
