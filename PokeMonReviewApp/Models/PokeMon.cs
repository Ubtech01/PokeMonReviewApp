namespace PokeMonReviewApp.Models
{
    public class PokeMon
    {
        public int Id { get; set; }
        public string name { get; set; }  
        public DateTime BirthDate { get; set; }

        public ICollection<review> Reviews { get; set; }
        public ICollection<PokeMonOwner> PokeMonOwner { get; set;}
        public ICollection<PokeMonCategory> PokeMonCategories { get; set;}    

    }
}
