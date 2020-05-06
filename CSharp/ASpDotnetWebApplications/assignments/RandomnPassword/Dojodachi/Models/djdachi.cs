using System;

namespace Dojodachi.Models
{
    public class djdachi
    {

        public int Happiness { get; set; }
        public int Fullness {get;set;}
        public int Energy{get;set;}
        public int Meals {get;set;}

        public string mystring{get;set;}
        public bool showBtnFlag {get;set;}

        public djdachi()
        {
            Happiness =20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            mystring="";
            showBtnFlag = false;
        }
        public djdachi(int happiness,int fullness, int energy,int meals)
        {
            Happiness =happiness;
            Fullness = fullness;
            Energy = energy;
            Meals = meals;
        }

        public void Feed()
        {
            if(Meals !=0)
            {
                Meals = Meals - 1;
                //Generate randomn fullness
                Random rnd = new Random();
                if(rnd.Next(1,4) == 1)
                {
                    Fullness =rnd.Next(5,10);
                    return;
                 }
            }            
            return;
        }

        public void Play()
        {
            if(Energy !=0)
            {
                Energy = Energy-5;
                //Generate randomn fullness
                Random rnd = new Random();
                if(rnd.Next(1,4) == 2)
                {
                    Happiness =rnd.Next(5,10);
                    return;
                }
            }
            return;
        }

        public int Work()
        {
            if(Energy !=0)
            {
                Energy = Energy-5;
                //Generate randomn fullness
                Random rnd = new Random();
                Happiness =rnd.Next(1,3);
                return 1;

            }
            return 0;
        }

        public int Sleep()
        {
            if(Energy !=0)
            {
                Energy = Energy+15;

                Happiness = Happiness -5;
                Fullness = Fullness -5;
                return 1;

            }
            return 0;
        }

        public int checkGameOver()
        {
            if(this.Happiness== 100 && this.Fullness== 100 && this.Energy==100 && this.Meals ==100)
            {
                return 1; //gameover
            }
            if(this.Happiness ==0 || this.Fullness ==0)
            {
                return -1;//gamefail
            }
            return 0;//still in  game
        }
    }
}