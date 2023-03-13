using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("Chris");
            name.Add("Kevin");
            name.Add("Alan");
            name.Add("Bringo");
            name.Add("Chiney");
            string action = "";


            Queue1 Queue = new Queue1(0, 4, 0, 1, name, 0);

            while (action != "end")
            {
                Console.WriteLine("what would you like to do");
                action = Console.ReadLine();

                switch (action)
                {
                    case "Add":
                        Queue.Add();
                        break;

                    case "Remove":
                        Queue.Remove();
                        break;

                    case "Read":
                        Queue.Read();
                        break;

                    case "isFull":
                        Queue.is_Full();
                        break;
                }
            }
        

        }
    }
}
