using System.Linq;
class DisemvowelComment
{
    public string RemoveAllVowelsFrom(string trollComment)
    {
        string vowels = "aeiou";

        return trollComment = new string(trollComment.Where(x => !vowels.Contains(x)).ToArray());
    }
}