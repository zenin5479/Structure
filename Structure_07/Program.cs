using System;

// Структуры
// Конструкторы

namespace Structure_07
{
   struct MyStruct
   {
      public int Field;

      // Пользовательский конструктор с параметрами
      public MyStruct(int value)
      {
         this.Field = value;

         Console.WriteLine(value);
      }
   }

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

         // Delay
         Console.ReadKey();
      }
   }
}