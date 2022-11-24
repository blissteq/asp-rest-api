using System;

namespace RecipesGuides.Abstraction
{
    public class Recipe
    {
          public string Name
    { get; set; }
        
          public string Description
    { get; set; }
        
             public string Steps
    { get; set; }
        
             public int Duration
    { get; set; }
        
             public string Ingredients
    { get; set; }
        
          public string Authors
    { get; set; }
        
           public string AddOns
    { get; set; }
    }
}
