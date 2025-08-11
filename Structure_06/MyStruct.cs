using System;

namespace Structure_06
{
   struct MyStruct
   {
      public int Field;

      // Статический конструктор всегда отрабатывает первым
      static MyStruct()
      {
         Console.WriteLine("Static Constructor");
      }

      // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля
      public MyStruct(int value)
      {
         Console.WriteLine("Constructor");
         Field = value;
      }
   }
}