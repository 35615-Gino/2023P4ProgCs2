using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\ginos\\OneDrive\\Documenten\\2023P4ProgCs2\\ConsoleMon\\monsterdata.txt");
            //Console.WriteLine(path);

            foreach (string line in lines)
            {
                string[] typesplit = line.Split('|');


                string[] consoleMonData = typesplit[0].Split(',');
                Console.WriteLine(line);
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.health = Convert.ToInt32(consoleMonData[2]);
                dataMon.energy = Convert.ToInt32(consoleMonData[4]);
                dataMon.weakness = (Element)Enum.Parse(typeof(Element), consoleMonData[6]);

                Console.WriteLine($"{dataMon.name} {dataMon.health} {dataMon.energy} {dataMon.weakness}");



            }
        }
        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText("monsterdata.json");
            
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
    }
}
