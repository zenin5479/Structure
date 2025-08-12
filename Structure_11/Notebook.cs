using System;

namespace Structure_11
{
   public struct Notebook
   {
      readonly string _producer;
      readonly double _price;
      readonly string _model;

      // Пользовательский конструктор, принимает 3 аргумента
      public Notebook(string model, string producer, double price)
      {
         _model = model;
         _producer = producer;
         _price = price;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(string model)
      {
         _producer = null;
         _price = 0;
         _model = model;
      }

      public Notebook(string model, string producer)
      {
         _producer = producer;
         _price = 0;
         _model = model;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(double price)
      {
         _price = price;
         _producer = null;
         _model = null;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
     

      // Метод отображения
      public void Show()
      {
         Console.WriteLine("Модель {0} от {1} стоимостью {2}$", _model, _producer, _price);
      }
   }
}