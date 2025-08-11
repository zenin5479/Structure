using System;

// Структуры
// Пример хорошего дизайна

namespace Structure_10
{
   class Program
   {
      static void Main()
      {
         ZipCode zipCode = new ZipCode(12345, 1234);
         Console.WriteLine(zipCode.FiveDigitCode);
         Console.WriteLine(zipCode.PlusFourExtension);
         Console.ReadKey();
      }
   }
}