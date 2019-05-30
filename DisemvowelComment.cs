using System.Linq;
using System;
using System.Collections.Generic;

class DisemvowelComment
{
    public List<string> RemoveAllVowelsFrom(List<string> trollComments)
    {
        string[] vowels = {"a","e","i","o","u"};

        List<string> alteredComments = new List<string>();

        foreach(var comment in trollComments)
        {
            string newComment = comment;

            foreach(var vowel in vowels)
            {
                newComment = newComment.Replace(vowel, "");
            }

            alteredComments.Add(newComment);
        }

        return alteredComments;
    }
}