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
         _fiveDigitCode = fiveDigitCode;
         _plusFourExtension = plusFourExtension;
      }

      public ZipCode(int fiveDigitCode)
      {
         _fiveDigitCode = 0;
         _plusFourExtension = 0;
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
}