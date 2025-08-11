using System;

namespace Structure_12
{
   public struct Train
   {
      // Создание закрытых полей класса
      private string _punkt;
      private int _nomer;
      private DateTime _time;

      // Пользовательский конструктор
      public Train(string punkt, int nomer, DateTime time)
      {
         // Инициализация полей класса
         this._punkt = punkt;
         this._nomer = nomer;
         this._time = time;
      }

      // Свойство для возвращения значения поля punkt
      public string Punkt
      {
         get { return _punkt; }
      }

      // Свойство для возвращения значения поля nomer
      public int Nomer
      {
         get { return _nomer; }
      }

      // Свойство для возвращения значения поля time
      public DateTime Time
      {
         get { return _time; }
      }
   }
}