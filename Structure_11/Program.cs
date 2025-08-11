using System;

namespace Structure_11
{
   internal class Program
   {
      static void Main()
      {
         // Создание екземпляра класса Notebook
         Notebook notebook1 = new Notebook();
         // Отображение полей класса
         notebook1.Show();
         // Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 3 параметра
         Notebook notebook2 = new Notebook("TT-45", "DELL", 570.99);
         notebook2.Show();
         //Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 1 параметр
         Notebook notebook3 = new Notebook("RR-34");
         notebook3.Show();
         Console.ReadKey();
      }
   }
}