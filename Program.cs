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
            var pathInput = $"{path}\\TrollComments.txt";

            FileStream fs = new FileStream(); 
            List<string> trollComments = fs.ReadFile(pathInput);
            
            DisemvowelComment remover = new DisemvowelComment();
            trollComments = remover.RemoveAllVowelsFrom(trollComments);

            var pathOutput = $"{path}\\OutputComments.txt";
            fs.WriteFile(trollComments, pathOutput);
        }
    }
}
