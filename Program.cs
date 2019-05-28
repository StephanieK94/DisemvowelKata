using System;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string troll = "Here is a trolling comment";

            DisemvowelComment disemvoweler = new DisemvowelComment();
            
            string neutralisedComment = disemvoweler.RemoveAllVowelsFrom(troll);
            Console.WriteLine(neutralisedComment);
        }
    }


}
