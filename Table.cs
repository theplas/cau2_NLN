using System;
using System.Collections.Generic;
namespace bai2
{
    internal class Table: ITable
    {
        public int TableId{get;set;}
        public DateTime StartTime{get;set;}
        public DateTime EndTime{get;set;}
        public long SumTotal{get;set;}
        List<OrderDetails> orderList = new List<OrderDetails>();
        public  void  ShowInfo(){
            Console.WriteLine("TableId:" + TableId);
            Console.WriteLine("StartTime:" + StartTime);
            Console.WriteLine("EndTime:" + EndTime);
            Console.WriteLine("SumTotal:" + SumTotal);
      }
      public  void  Pay(){
            foreach(OrderDetails item in orderList)
            {
                SumTotal+= item.Total;
            }
      }
        internal void Display()
        {
        }
    }
}