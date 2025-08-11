using System;

// Структуры
// Пример хорошего дизайна

namespace Structure_10
{
   struct ZipCode
   {
      // Поля
      int _fiveDigitCode;
      int _plusFourExtension;

      // Конструкторы
      public ZipCode(int fiveDigitCode, int plusFourExtension)
      {
         this._fiveDigitCode = fiveDigitCode;
         this._plusFourExtension = plusFourExtension;
      }

      public ZipCode(int fiveDigitCode)
         : this(fiveDigitCode, 0)
      {
      }

      // Свойства
      public int FiveDigitCode
      {
         get { return _fiveDigitCode; }
      }

      public int PlusFourExtension
      {
         get { return _plusFourExtension; }
      }
   }

   class Program
   {
      static void Main()
      {
         ZipCode zipCode = new ZipCode(12345, 1234);

         Console.WriteLine(zipCode.FiveDigitCode);
         Console.WriteLine(zipCode.PlusFourExtension);

         // Delay
         Console.ReadKey();
      }
   }
}