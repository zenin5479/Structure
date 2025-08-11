using System;

// Структуры

namespace Structure_03
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа с вызовом конструктора по умолчанию
         MyStruct instance = new MyStruct();
         Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}