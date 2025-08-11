using System;

// Структуры
// Статический конструктор

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
         this.Field = value;
      }
   }

   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа, с вызовом пользовательского конструктора
         MyStruct instance = new MyStruct { Field = 0 };

         Console.WriteLine(instance.Field);

         // Delay
         Console.ReadKey();
      }
   }
}