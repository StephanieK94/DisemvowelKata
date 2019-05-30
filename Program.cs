using System;
using System.IO;
using System.Collections.Generic;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fr = new FileReader();
            
            List<string> trollComments = fr.ReadFile();

            DisemvowelComment remover = new DisemvowelComment();
            remover.RemoveAllVowelsFrom(trollComments);
        }
    }
}
