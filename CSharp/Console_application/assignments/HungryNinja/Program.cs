using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name,int cal,bool spicy,bool sweet)
        {
            Name = name;
            Calories= cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Fried Chicken", 1000, false, false),
                new Food("Donut", 900, false, true),
                new Food("Buffalo wings", 800, true, false),
                new Food("Sweet and Sour pork", 1000, true, true),
                new Food("boring 1", 1000, true, false),
                new Food("b0ring 2", 1000, false, true),
                new Food("boring 3", 1000, false, true),
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,Menu.Count)];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // add a public "getter" property called "IsFull"
        public bool isFull{
            get 
            {
                return (this.calorieIntake>1200? true:false);
            }
            
        }
        
        // build out the Eat method
        // build out the Eat method that: if the Ninja is NOT full
        // adds calorie value to ninja's total calorieIntake
        // adds the randomly selected Food object to ninja's FoodHistory list
        // writes the Food's Name - and if it is spicy/sweet to the console
        // if the Ninja IS full
        // issues a warning to the console that the ninja is full and cannot eat anymore
        public void Eat(Food item)
        {
            if(!this.isFull){
                calorieIntake+=item.Calories;
                this.FoodHistory.Add(item);

                Console.WriteLine("Food Name : "+item.Name);
                if(item.IsSpicy && item.IsSweet)
                {
                 Console.Write("is Sweet and spicy");   
                }
                else if(item.IsSpicy)
                {
                    Console.Write(" is spicy");
                }
                else if(item.IsSweet){
                    Console.Write(" is sweet");

                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Warning!!! Ninja is Full and cannot eat anymore!");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            Ninja nj1 = new Ninja();
            nj1.Eat(b1.Serve());
            nj1.Eat(b1.Serve());
            nj1.Eat(b1.Serve());
            nj1.Eat(b1.Serve());




        }
    }
}
