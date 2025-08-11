using System;

// Структуры

namespace Structure_04
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа, с вызовом пользовательского конструктора          
         MyStruct instance = new MyStruct(1);
         Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}