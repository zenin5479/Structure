using System;

namespace Structure_11
{
   public struct Notebook
   {
      readonly string _producer;
      readonly double _price;
      readonly int _model;

      // Пользовательский конструктор, принимает 3 аргумента
      public Notebook(string producer, int model, double price)
      {
         _producer = producer;
         _model = model;
         _price = price;
      }

      // Перегрузка пользовательского конструктора, принимает 2 аргумента
      public Notebook(int model, string producer)
      {
         _producer = producer;
         _price = 0;
         _model = model;
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент
      public Notebook(int model)
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
         _model = 0;
      }

      // Метод отображения
      public void Show()
      {
         Console.WriteLine("Производитель: {0} Модель: {1} Cтоимость ${2}", _producer, _model, _price);
      }
   }
}