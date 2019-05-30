using System.Linq;
using System;
using System.Collections.Generic;

class DisemvowelComment
{
    public void RemoveAllVowelsFrom(List<string> trollComments)
    {
        char[] vowels = {'a','e','i','o','u'};
        //string vowels ="aeiou";

        List<string> alteredComments = new List<string>();

        foreach(var comment in trollComments)
        {
            string newComment = comment;

            foreach(var vowel in vowels)
            {
                newComment = newComment.Replace(vowel.ToString(), "");
            }

            //string newComment = new string(comment.Where(x => !vowels.Contains(x)).ToArray());
            
            alteredComments.Add(newComment);
        }

        PrintDisemvoweledComment(alteredComments);
    }

    private void PrintDisemvoweledComment(List<string> commentsList)
    {
        foreach(string comment in commentsList)
        {
            Console.WriteLine($"Your troll's comment has now been reduced to: \"{comment}\"");      // return this to console
        }
    }
}