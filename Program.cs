using System;
using System.Collections.Generic;
namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
           Program n = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("1.NewOrder");
                Console.WriteLine("2.UpdateOrder ");
                Console.WriteLine("3.CancelOrder ");
                Console.WriteLine("4.Search ");
                Console.WriteLine("5.Pay ");
                Console.WriteLine("6. Exit ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        n.NewOrder();
                        break;
                    case 2:
                        n.UpdateOrder();
                        break;
                    case 3:
                        n.CancelOrder();
                        break;
                        case 4:
                        n.Search();
                        break;
                         case 5:
                        n.Pay();
                        break;
                    case 6:
                        return;
                }
            } while (choice != 7);
        }
        int count = 0;
      public  Dictionary<int, Table> ListTable = new Dictionary<int, Table>();
       public Coffee coffee = new Coffee();
        public void NewOrder()
        {
            Table tables = new Table();
            tables.TableId = count;
            Console.WriteLine("");
            tables.StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
             tables.StartTime =  DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
            tables.SumTotal = long.Parse(Console.ReadLine());
            Console.WriteLine("");
            tables.SumTotal = int.Parse(Console.ReadLine());

             
        }
        public void UpdateOrder()
        {
            foreach (Table item in ListTable.Values)
            {
                item.Display();
            }
        }
        public void CancelOrder()
        {
            foreach (Table item in ListTable.Values)
            {
                item.Display();
            }
        }
 public void Search()
        {
        }
        public void Pay()
        {
            foreach (Table item in ListTable.Values)
            {
                item.Display();
            }
        }
    }
        }