using System;
using System.Collections.Generic;
using System.IO;
class FileReader
{
    public List<string> ReadFile()
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

            return trollComments;
        }
    }
}