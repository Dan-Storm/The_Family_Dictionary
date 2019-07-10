using System;
using System.Collections.Generic;

namespace The_Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Deep"},
            {"age", "25"}
            });

            myFamily.Add("cousin", new Dictionary<string, string>(){
            {"name", "Joey"},
            {"age", "26"}
            });

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Logan"},
            {"age", "16"}
            });
            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and they are {familyMember.Value["age"]} years old");
            }
        }
        
    }
}
