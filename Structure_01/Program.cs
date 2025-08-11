using System;

// Структуры
// В структурах нельзя инициализировать поля непосредственно в месте создания

namespace Structure_01
{
   struct MyStruct
   {
      public int field;
   }

   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа, без вызова конструктора
         MyStruct instance;

         // Закомментировать
         instance.field = 1;

         // Попытка вывода значения неинициализированного поля приведет к ошибке
         Console.WriteLine(instance.field);

         // Delay
         Console.ReadKey();
      }
   }
}