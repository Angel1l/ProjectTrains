using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace VEZIMENAMOYPOEZD.Model
{
   public class JsonPars
    {
        public static List<TripModel> ReadFromFile(string path)
        {
            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] array = new byte[fstream.Length];
                // асинхронное чтение файла
                 fstream.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);

                List<TripModel> peozd = JsonConvert.DeserializeObject<List <TripModel>>(textFromFile);

                return peozd;
            }
        }
    }
}
