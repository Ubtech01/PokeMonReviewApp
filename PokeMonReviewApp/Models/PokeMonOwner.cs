namespace PokeMonReviewApp.Models
{
    public class PokeMonOwner
    {
        public int PokeMonId { get; set; }  
        public int OwnerId { get; set; }    
        public PokeMon PokeMan { get; set; }    
        public Owner Owner { get; set; }
    }
}
