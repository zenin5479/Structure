using System;

// Структуры
// Статический конструктор

namespace Structure_06
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа, с вызовом пользовательского конструктора
         MyStruct instance = new MyStruct { Field = 0 };
         Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}