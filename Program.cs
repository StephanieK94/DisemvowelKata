using System;
using System.IO;
using System.Collections.Generic;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();

            using(StreamReader sr = new StreamReader($"{path}\\TrollComments.txt"))
            {
                List<string> trollComments = new List<string>();

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    trollComments.Add(line);
                }

                DisemvowelComment remover = new DisemvowelComment();
                remover.RemoveAllVowelsFrom(trollComments);
            }

        }
    }


}
