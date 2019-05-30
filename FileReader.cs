using System;
using System.Collections.Generic;
using System.IO;
class FileStream
{
    public List<string> ReadFile(string pathName)
    {
        using(StreamReader sr = new StreamReader($"{pathName}"))
        {
            List<string> trollComments = new List<string>();

            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                trollComments.Add(line);
            }

            return trollComments;
        }
    }

    public void WriteFile(List<string> alteredTrollComments, string pathName)
    {
        using(StreamWriter sw = new StreamWriter(pathName))
        {
            sw.WriteLine("Here are your trolls comments now: ");
            
            foreach(var line in alteredTrollComments)
            {
                sw.WriteLine(line);
            }
        }
    }
}