using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3_var3
{
    public class FileDrugStorage : Dobavlenie
    {
        List<Films> Dobavlenie.LoadDataFromCsv()
        { 
            List<Films> result = new List<Films>();
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] drugInfo = line.Split(' ');
                    Films film = new Films(drugInfo[0], drugInfo[1], drugInfo[2], drugInfo[3], drugInfo[4], drugInfo[5], drugInfo[6]);
                    result.Add(film);
                }
            }
            return result;
        }
    }
}
