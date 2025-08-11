using System;

// Структуры
// Конструкторы

namespace Structure_07
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа без вызова конструктора
         MyStruct instance;
         // Нельзя использовать не инициализированную переменную
         // Так как конструктор не вызывался переменная field осталась не инициализированной
         // Убрать комментарий
         //Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}