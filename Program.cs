using System;
using System.IO;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();

            using(StreamReader sr = new StreamReader($"{path}\\TrollComments.txt"))
            {
                while(!sr.EndOfStream)
                {
                    //var count =1;
                    string trollComment = sr.ReadLine();

                    DisemvowelComment disemvoweler = new DisemvowelComment();
                    
                    string neutralisedComment = disemvoweler.RemoveAllVowelsFrom(trollComment);
                    
                    Console.WriteLine($"Your troll's comment has now been reduced to: \"{neutralisedComment}\"");
                    //count++;
                }
            }

        }
    }


}
