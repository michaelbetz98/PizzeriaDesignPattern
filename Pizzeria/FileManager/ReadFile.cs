using System;

namespace FileManager
{
    public static class ReadFile //ok static?
    {
        public static List<string> ReadFileLines() //Ok usare static?  
        {
            List<string> lines = new();
            try 
		    {	   
                using (StreamReader fileToRead = new StreamReader("FileManager\\file.csv"))
                {
                    while(!fileToRead.EndOfStream)
                    {
                        lines.Add(fileToRead.ReadLine());
                    }
                }
            }

		    catch (global::System.Exception)
		    {
			    throw;
		    }
            return lines;
        }
       
    }
}
