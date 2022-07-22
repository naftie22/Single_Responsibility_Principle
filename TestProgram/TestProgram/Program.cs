using System;
using Domain;
using ValueObjects;

namespace TestProgram
{
    public static class TestClass
    {
        public static void Main()
        {
            var a = new TradeProcessor();            
            a.ProcessTrades(@"C:\Users\PEOPLE POWER I.P.S\Desktop\SRP\Domain\data.txt");

        }
    }
}
