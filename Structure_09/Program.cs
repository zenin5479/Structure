using System;

// Структуры
// Пример плохого дизайна

namespace Structure_09
{
   class Program
   {
      static void Main()
      {
         ZipCode zipCode = new ZipCode();
         zipCode.FiveDigitCode = 12345;
         zipCode.PlusFourExtension = 1234;
         Console.WriteLine(zipCode.FiveDigitCode);
         Console.WriteLine(zipCode.PlusFourExtension);
         Console.ReadKey();
      }
   }
}