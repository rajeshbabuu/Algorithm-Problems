using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BinarySearchWord
    {
        public string FilePath = @"D:\RFP-244\Algorithm-Problem\Algorithm-Problems\AlgorithmPrograms\WordFile.json";

        public void WordExistsOrNot()
        {
            string words = "OOPS,Array,Dictionary,Generics,Delegates,Linked List,Stack,Queue,Hash Table,Events,Regular Expressions";
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(words));

            string wordData = File.ReadAllText(FilePath);
            string word = JsonConvert.DeserializeObject<string>(wordData);
            List<string> wordList = word.Split(',').ToList<string>();
            wordList.Sort();

            Console.WriteLine("Enter a Word to Search: ");
            string wordToSearch = Console.ReadLine();

            int index = wordList.BinarySearch(wordToSearch);

            if (index < 0)
            {
                Console.WriteLine($"{wordToSearch} does not exist");
            }
            else
            {
                Console.WriteLine($"{wordToSearch} exists");
            }
        }
    }
}