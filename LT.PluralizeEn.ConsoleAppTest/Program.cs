using System;
using LT.PluralizeEn;

namespace LT.PluralizeEn.ConsoleAppTest
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var myPluralizer = new Pluralizer();
            
            Console.WriteLine(myPluralizer.Pluralize("man"));

            Console.WriteLine(myPluralizer.Singularize("men"));

            Console.WriteLine(myPluralizer.Pluralize("shop"));

            Console.WriteLine(myPluralizer.Pluralize("hash"));

            Console.WriteLine(myPluralizer.Singularize("pets"));
        }
    }
}
