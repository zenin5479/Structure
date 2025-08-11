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
}