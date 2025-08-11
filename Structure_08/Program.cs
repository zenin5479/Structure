using System;

// Структуры
// В структурах можно создавать автоматически реализуемые свойства,
// при этом требуется использовать конструктор при построении экземпляра

namespace Structure_08
{
   class Program
   {
      static void Main()
      {
         MyStruct instance = new MyStruct();
         instance.MyProperty = 1;
         Console.WriteLine(instance.MyProperty);
         Console.ReadKey();
      }
   }
}