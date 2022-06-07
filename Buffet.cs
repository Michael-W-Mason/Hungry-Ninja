public class Buffet
{
    public List<Food> Menu;
    
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Beef", 1000, true, true),
            new Food("Chicken", 900, false, true),
            new Food("Pork", 1200, true, false),
            new Food("Vegetarian", 500, false, false),
            new Food("Fish", 100, true, true),
            new Food("Vegan", 10, false, false),
            new Food("Paleo", 1, false, true)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        return Menu[rand.Next(0, Menu.Count)];
    }
}

