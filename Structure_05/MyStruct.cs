using System;

namespace Structure_05
{
   struct MyStruct
   {
      public static int Field
      {
         get;
         set;
      }

      public static void Show()
      {
         Console.WriteLine(Field);
      }
   }
}