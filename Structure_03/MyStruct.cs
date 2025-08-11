using System;

namespace Structure_03
{
   struct MyStruct
   {
      public int Field;

      // Конструкторы по умолчанию нельзя задавать явно
      //public MyStruct()
      //{
      //}

      // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля
      public MyStruct(int value)
      {
         Console.WriteLine("Constructor");
         Field = value;
      }
   }
}