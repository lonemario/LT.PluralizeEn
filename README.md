# LT.PluralizeEn
[![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg)](https://www.nuget.org/packages/LT.PluralizeEn)

Pluralize or singularize any word. NET Standard 2.0 C#  Port of Blake Embrey's pluralize library for Javascript.

## Prerequisites

### .NETStandard 2.0

## Example 

The SettingsManager must be initialized before use. Use Init(string initVector, string passPhrase, string user, string app) method. It is sufficient to initialize the class only once in the application

```c#
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
```

### Authors

- [Mario Righi](http://www.mariorighi.com)

### License

This project is licensed under the [MIT License](https://choosealicense.com/licenses/mit/)