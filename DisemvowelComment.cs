using System.Linq;
using System;
using System.Collections.Generic;

class DisemvowelComment
{
    public void RemoveAllVowelsFrom(List<string> trollComments)
    {
        string vowels = "aeiou";

        List<string> alteredComments = new List<string>();

        foreach(var comment in trollComments)
        {
            string temp = new string(comment.Where(x => !vowels.Contains(x)).ToArray());
            alteredComments.Add(temp);
        }

        PrintDisemvoweledComment(alteredComments);
    }

    private void PrintDisemvoweledComment(List<string> commentsList)
    {
        foreach(string comment in commentsList)
        {
            Console.WriteLine($"Your troll's comment has now been reduced to: \"{comment}\"");
        }
    }
}