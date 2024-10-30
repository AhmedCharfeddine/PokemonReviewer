namespace PokemonReviewer.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        // many2many with Pokemon
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
