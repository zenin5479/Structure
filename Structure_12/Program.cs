using System;

namespace Structure_12
{
   internal class Program
   {
      static void Main()
      {
         // Создание массива типа Train из двух элементов
         Train[] train = new Train[2];
         // Вызов метода для создания нового екземпляра класса Train
         MyClass.AddingAnArray(train);
         // 50 почеркиваний
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Вы ввели такую информацию о поездах:");
         // 50 почеркиваний
         Console.WriteLine(new string('-', 50));
         // Вызов метода сортировки массива
         MyClass.Sort(train);
         // Вызов метода отображения содержимого массива
         MyClass.Show(train);
         // 50 почеркиваний
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Введите номер поезда:");
         int poisk = Convert.ToInt32(Console.ReadLine());
         // 50 почеркиваний
         Console.WriteLine(new string('-', 50));
         // Поиск в массиве
         MyClass.Search(train, poisk); 
         //Delay
         Console.ReadKey();
      }
   }
}