using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Queue
{
    class Queue1
    {

        public int start = 0;
        public int end = 4;
        public int isFull = 0;
        public int space = 1;
        public string action = "";
        public int full;
        List<string> name = new List<string>();


        public Queue1(int start, int end, int isFull, int space, List<string> name, int full)
        {
            this.start = start;
            this.end = end;
            this.name = name;
            this.full = full;
            this.space = space;
            this.isFull = isFull;

        }
        public void Add()
        {
            full = 0;
            Console.WriteLine("What would you like to add");
            string names = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                if (name[i] == "")
                {
                    name[i] = names;
                    end = i;
                    i = 5;
                }
                else
                {
                    full++;
                }

                if(full == 5)
                {
                    Console.WriteLine("Queue is full!");
                }
            }
        }

        public void Remove()
        {
            name[start] = "";
            if (start != 4)
            {
                start = start + 1;
            }
            else
            {
                start = 0;
            }
        }
        public void is_Full()
        {
             for(int i = 0; i <= 4; i++)
      {
        if(name[i] != "")
        {
          isFull++;
        }
        else
        {
          Console.WriteLine("the queue has " + space + " spaces");
          space++;
        }
      }
      if(isFull == 5)
      {
        Console.WriteLine("the queue is full");
      }
        }
        public void Read()
        {
            Console.WriteLine("Your current queue is: ");
            foreach (string i in name)
            {
                Console.WriteLine(i);

            }



        }




    }
}
