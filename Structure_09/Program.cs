using System;

// Структуры
// Пример плохого дизайна

namespace Structure_09
{
   struct ZipCode
   {
      // Поля
      int _fiveDigitCode;
      int _plusFourExtension;

      // Свойства
      public int FiveDigitCode
      {
         get { return _fiveDigitCode; }
         set { _fiveDigitCode = value; }
      }

      public int PlusFourExtension
      {
         get { return _plusFourExtension; }
         set { _plusFourExtension = value; }
      }
   }

   class Program
   {
      static void Main()
      {
         ZipCode zipCode = new ZipCode();

         zipCode.FiveDigitCode = 12345;
         zipCode.PlusFourExtension = 1234;

         Console.WriteLine(zipCode.FiveDigitCode);
         Console.WriteLine(zipCode.PlusFourExtension);

         // Delay
         Console.ReadKey();
      }
   }
}