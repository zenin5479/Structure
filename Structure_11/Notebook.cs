using System;

namespace Structure_11
{
   public struct Notebook
   {
      readonly string _producer;
      readonly double _price;
      readonly string _model;

      // Пользовательский конструктор, принимает 3 аргумента
      public Notebook(string producer, string model, double price)
      {
         _producer = producer;
         _model = model;
         _price = price;
      }

      // Перегрузка пользовательского конструктора, принимает 2 аргумента
      public Notebook(string model, string producer)
      {
         _producer = producer;
         _price = 0;
         _model = model;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(string model)
      {
         _producer = null;
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

      // Метод отображения
      public void Show()
      {
         Console.WriteLine("Производитель: {0}; Модель: {1} стоимостью {2}$",_producer, _model,  _price);
      }
   }
}