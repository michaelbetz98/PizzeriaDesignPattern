using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.FileManager
{
    public class LinesSplitter
    {
        public List<string> Lines;

        public List<string> SplittedLine(string line)
        {
            var splitted = new List<string>();
            //splitted = line.Split(new[]{';',','},2).ToList();
            line.Replace(',',';');
            splitted = line.Split(";").ToList();
            var ingredients = splitted[2].Split(",").ToList();
            splitted.RemoveAt(2);
            splitted.AddRange(ingredients);
            return splitted;
        }
    }
}
