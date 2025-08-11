using System;

// Структуры
// Если в структуре имеются члены, которые обращаются к полю и нет пользовательского конструктора,
//  то требуется при создании экземпляра вызывать конструктор по умолчанию (Иначе будет ошибка)

namespace Structure_02
{
   class Program
   {
      static void Main()
      {
         // Создание экземпляра структурного типа с вызовом конструктора по умолчанию
         MyStruct instance = new MyStruct();
         instance.Field = 1;
         Console.WriteLine(instance.Field);
         Console.ReadKey();
      }
   }
}