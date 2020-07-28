using System;

namespace Human
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int myhealth{
            get 
            {
                //Console.WriteLine("get: this.health :" +this.health);
                return this.health;
            }
            set
            {
                //Console.WriteLine("set: this.health :" +this.health);
                this.health = value;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            myhealth = 100;
        }
        
        
        // Add a constructor to assign custom values to all fields
        public Human(string name,int str,int intl,int dext,int myh)
        {
            Name = name;
            Strength = str;
            Intelligence = intl;
            Dexterity = dext;
            myhealth = myh;
        }
        
        // Build Attack method
        // Now add a new method called Attack, which when invoked, should reduce the health 
        // of a Human object that is passed as a parameter. The damage done should be 5 * strength 
        // (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return
        //  the remaining health of the target object.
        public int Attack(Human target)
        {
            int damage = 5* target.Strength;
            target.myhealth -=damage;
            return target.myhealth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human h1 = new Human("Shania");
            Console.WriteLine("Name: "+h1.Name+" Strength: "+h1.Strength+" Health : "+h1.myhealth);
            Human h2 = new Human("Oliver",5,5,3,99);
            Console.WriteLine("Name: "+h2.Name+" Strength: "+h2.Strength+" Health : "+h2.myhealth);
            Console.WriteLine("After Attack");
            h2.Attack(h1);
            Console.WriteLine("Name: "+h1.Name+" Strength: "+h1.Strength+" Health : "+h1.myhealth);
            h1.Attack(h2);
            Console.WriteLine("Name: "+h2.Name+" Strength: "+h2.Strength+" Health : "+h2.myhealth);
        }
    }
}
