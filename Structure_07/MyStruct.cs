using System;

namespace Structure_07
{
   struct MyStruct
   {
      public int Field;

      // Пользовательский конструктор с параметрами
      public MyStruct(int value)
      {
         Field = value;

         Console.WriteLine(value);
      }
   }
}