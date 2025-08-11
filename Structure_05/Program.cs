using System;

// Структуры
// Структуры могут содержать статические члены
// Статические структуры недопустимы

namespace Structure_05
{
   class Program
   {
      static void Main()
      {
         // Инициализация статических полей необязательна
         //MyStruct.Field = 1;
         MyStruct.Show();
         Console.ReadKey();
      }
   }
}