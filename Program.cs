
using System;
using DnD.Helpers;

namespace DnD
{
    
    public class Program
    {
        public static void Main(String[] args)
        {
            Array a = EnumHelper.GetRandomEnum<Race>();
            foreach(var algo in a)
            {
                Console.WriteLine(algo.ToString());
            }
        }
    }
}