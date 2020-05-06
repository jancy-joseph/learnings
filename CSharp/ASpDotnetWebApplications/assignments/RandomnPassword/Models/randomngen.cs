using System;
using System.Text;

namespace RandomnPassword.Models
{
    public static class randomngen
    {
        public static string GenerateString(int length, Random random) 
        {
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++) {
                result.Append(characters[random.Next(characters.Length)]);
             }
            return result.ToString();
        }
        
    }
}