using System;

// Структуры
// В структурах нельзя инициализировать поля непосредственно в месте создания

namespace Structure_01
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа, без вызова конструктора
         MyStruct instance;
         // Закомментировать
         instance.Field = 1;
         // Попытка вывода значения неинициализированного поля приведет к ошибке
         Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}