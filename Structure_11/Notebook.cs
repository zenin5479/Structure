using System;

namespace Structure_11
{
   public struct Notebook
   {
      readonly string _producer;
      readonly double _price;

      // Свойство только для чтения поля model
      public string Model
      {
         get;
      }

      // Свойство только для чтения поля producer
      public string Producer
      {
         get { return _producer; }
      }

      // Свойство только для чтения поля price
      public double Price
      {
         get { return _price; }
      }

      // Пользовательский конструктор, принимает 3 аргумента
      public Notebook(string model, string producer, double price)
      {
         Model = model;
         _producer = producer;
         _price = Math.Abs(price);
      }

      // Перегрузка пользовательского конструктора, принимает 1 аргумент и вызывает конструктор принимающий 3 аргумента
      public Notebook(string model) : this(model, "", 0)
      {
      }

      //Перегрузка пользовательского конструктора, принимает 1 аргумент и вызывает конструктор принимающий 3 аргумента
      public Notebook(double price) : this("", "", price)
      {
      }

      // Метод отображения
      public void Show()
      {
         Console.WriteLine("Модель {0} от {1} стоимостью {2}$", Model, _producer, _price);
      }
   }
}