using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11OOPS
{
    internal class FetchInventoryDetails
    {
        public Inventory Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Inventory>(json);

                }
                catch (Exception e) //run time error catch
                {
                    Console.WriteLine(e);
                    return null;
                }
            }
        }
    }
}
