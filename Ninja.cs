class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    // add a constructor
    public Ninja(){
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull {
        get{
            if(calorieIntake >= 1200){            
                return true;
            }
            return false;
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if(!IsFull){
            FoodHistory.Add(item);
            calorieIntake += item.Calories;
            Console.WriteLine($"I ate {item.Name} and it was {(item.IsSweet || item.IsSpicy? string.Empty : "Tasteless")}{(item.IsSpicy? "Spicy": string.Empty)} {(item.IsSweet? "Sweet": string.Empty)}");
        }
        else{
            Console.WriteLine("I'm too full");
        }
    }
}

