using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
         public struct ThreeArrays{
            public int [] firstarr;
            public string [] secondarr;

            public bool [] thiradrr;


        }
    public class MyCollections
    {    
        //Exercises:
        // Three Basic Arrays
       
        public ThreeArrays createThreeArrays()
        {
            ThreeArrays myArr= new ThreeArrays();
            // Create an array to hold integer values 0 through 9
            int [] arr1 = new int[]{0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine("arr1 contents :");
            foreach( int i in arr1){
                Console.Write(arr1[i]+",");
            }
            Console.WriteLine();
            myArr.firstarr = arr1;
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] arr2 = new string[]{"Tim", "Martin", "Nikki","Sara"};
            Console.WriteLine("arr2 contents :");
            for(int i =0;i<arr2.Length; i++){
                if(i!= arr2.Length -1)
                {
                    Console.Write(arr2[i]+",");
                }
                else
                {
                  Console.Write(arr2[i]);  
                }
            }
            Console.WriteLine();
            myArr.secondarr = arr2;

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] arr3 = new bool[10];
            Console.WriteLine("arr3 Length is :"+arr3.Length +"arr3 values:");
            for(int i =0;i<arr3.Length;i++)
            {
                if( i == 0){
                    arr3[i] =true;
                    Console.Write( arr3[i]+",");
                }
                else{
                    if (arr3[i-1])
                    {
                        arr3[i] = false;
                        Console.Write( arr3[i]+",");
                    }
                    else
                    {
                        arr3[i] = true;
                        Console.Write( arr3[i]+",");
                    }
                }

            }
            Console.WriteLine();
            myArr.thiradrr = arr3;

            return myArr;

        }
        // List of Flavors
        public List<string> ListofFavours()
        {
            Console.WriteLine("Creating new list .....");
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavoursList = new List<string>();
            flavoursList.Add("vanilla");
            flavoursList.Add("chocolate");
            flavoursList.Add("strawberry");
            flavoursList.Add("English Toffee");
            flavoursList.Add("Caramel Choclate Chip");
            Console.WriteLine("List elements:");
            foreach(string i in flavoursList)
            {
                Console.Write(i+",");
            }
            // Output the length of this list after building it
            Console.WriteLine("\nFlavourslist Length : "+ flavoursList.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine("Third flavour is : "+flavoursList[2]);
            Console.WriteLine("Removing third flavor");
            flavoursList.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine("Flavourslist new Length : "+ flavoursList.Count);
            Console.WriteLine("List updated elements:");
            foreach(string i in flavoursList)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
            
            return flavoursList;

        }
        // User Info Dictionary
        public void myDictionary(ThreeArrays arraycollection,List<string> newflavorlist)
        {
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> newdict  = new Dictionary<string,string>();
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            for (int i =0 ; i<arraycollection.secondarr.Length;i++)
            {
                newdict[arraycollection.secondarr[i]] = newflavorlist[rand.Next(0,newflavorlist.Count)];
            }
            
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor

            foreach(KeyValuePair<string,string> i in newdict)
            {
                Console.WriteLine(" User name : "+ i.Key+" Icecream : "+i.Value);
            }

        }
    
    }

    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyCollections myCollections = new MyCollections();
            ThreeArrays arrcollection =  myCollections.createThreeArrays();
            List<string> resultlist = myCollections.ListofFavours();
            myCollections.myDictionary(arrcollection,resultlist);
        }
    }
}
