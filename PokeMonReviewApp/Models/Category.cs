﻿namespace PokeMonReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public ICollection<PokeMonCategory> PokeMonCategories { get; set; }
    }
}
