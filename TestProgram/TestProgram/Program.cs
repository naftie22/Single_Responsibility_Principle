using System;
using Domain;
using ValueObjects;
using Domain.models;
using System.Linq;

namespace TestProgram
{
    public static class TestClass
    {
        public static void Main()
        {
            //var a = new TradeProcessor();            
            //a.ProcessTrades(@"C:\Users\PEOPLE POWER I.P.S\Desktop\SRP\Domain\data.txt");

            var data = new Traderecord(){
                Id = "ABD345",
                ClientName = "Kasozi",
                ItemName = "Laptop",
                ItemQuantity = 3,
                UnitPrice = 100m,
                TotalPrice = 300m
            };
            var db = new traderecorddbContext();
            db.Traderecords.Add(data);
            db.SaveChanges();
            Console.WriteLine("Addition successful");
        }
    }
}
