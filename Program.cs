namespace Day11OOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:/Users/kambl/OneDrive/Desktop/RFP208/Day11OOPS/Inventory.json";
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();
            Inventory data = fetchInventoryDetails.Read(path);
            Console.WriteLine("---------------");
            Console.WriteLine("Inventory Details");
            Console.WriteLine("--------------");

            Console.WriteLine("Types Of Rice");

            for (int i = 0; i < data.typesofRice.Count; i++)
            {
                //Console.WriteLine(data.typesofRice[i].name);
                //Console.WriteLine(data.typesofRice[i].weight);
                //Console.WriteLine(data.typesofRice[i].price);
                int val = data.typesofRice[i].weight * data.typesofRice[i].price;
                Console.WriteLine("The Price for {0}kg of type {1} is {2} ", data.typesofRice[i].weight, data.typesofRice[i].price, val);
                Console.WriteLine("--------------------------------------");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Types Of Pulses");

            for (int i = 0; i < data.typesofPulses.Count; i++)
            {
                //Console.WriteLine(data.typesofPulses[i].name);
                //Console.WriteLine(data.typesofPulses[i].weight);
                //Console.WriteLine(data.typesofPulses[i].price);
                int val = data.typesofPulses[i].weight * data.typesofPulses[i].price;
                Console.WriteLine("The Price for {0}kg of type {1} is {2} ", data.typesofPulses[i].weight, data.typesofPulses[i].price, val);
                Console.WriteLine("--------------------------------------");
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Types Of Wheats");

            for (int i = 0; i < data.typesofWheats.Count; i++)
            {
                //Console.WriteLine(data.typesofWheats[i].name);
                //Console.WriteLine(data.typesofWheats[i].weight);
                //Console.WriteLine(data.typesofWheats[i].price);
                int val = data.typesofWheats[i].weight * data.typesofWheats[i].price;
                Console.WriteLine("The Price for {0}kg of type {1} is {2} ", data.typesofWheats[i].weight, data.typesofWheats[i].price, val);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("----------------");
        }
    }
}