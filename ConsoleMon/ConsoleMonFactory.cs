using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string path = File.ReadAllText("C:\\Users\\ginos\\OneDrive\\Documenten\\2023P4ProgCs2\\ConsoleMon\\monsterdata.txt");
            Console.WriteLine(path);
        }
    }
}
