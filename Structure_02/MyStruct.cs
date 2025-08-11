using System;

namespace Structure_02
{
   struct MyStruct
   {
      private int _field;

      public int Field
      {
         get { return _field; }
         set { _field = value; }
      }

      public void Show()
      {
         Console.WriteLine(_field);
      }
   }
}