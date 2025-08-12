using System;

namespace Structure_11
{
   public struct Notebook
   {
      readonly string _producer;
      readonly double _price;
      private readonly string Model;

      

      // Пользовательский конструктор, принимает 3 аргумента
      public Notebook(string model, string producer, double price)
      {
         Model = model;
         _producer = producer;
         _price = price;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(string model)
      {
         _producer = null;
         _price = 0;
         Model = model;
      }

      //Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(double price)
      {
         _price = price;
         _producer = null;
         Model = null;
      }

      // Метод отображения
      public void Show()
      {
         Console.WriteLine("Модель {0} от {1} стоимостью {2}$", Model, _producer, _price);
      }
   }
}