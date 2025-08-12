using System;

namespace Structure_11
{
   internal class Program
   {
      static void Main()
      {
         // Создание екземпляра класса Notebook
         Notebook notebook1 = new Notebook("DELL", "Latitude 5420", 422.27);
         // Отображение полей класса
         notebook1.Show();
         // Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 3 параметра
         Notebook notebook2 = new Notebook("Vostro 5301", "DELL");
         notebook2.Show();
         //Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 1 параметр
         Notebook notebook3 = new Notebook("Inspiron 5440");
         notebook3.Show();
         //Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 1 параметр
         Notebook notebook4 = new Notebook(96.67);
         notebook4.Show();
         Console.ReadKey();
      }
   }
}