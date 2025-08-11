using System;

namespace Structure_13
{
   // Класс
   class MyClass
   {
      public string change;
   }

   // Струкрура
   struct MyStruct
   {
      public string change;
   }

   internal class Program
   {
      // Статический метод для внесения изменений в поле класса change
      static void ClassTaker(MyClass c)
      {
         c.change = "изменено";
      }

      // Статический метод для внесения изменений в поле структуры change
      static void StructTaker(MyStruct s)
      {
         s.change = "изменено";
      }

      static void Main()
      {
         // Создание экземпляра класса
         MyClass testClass = new MyClass();
         // Создание структуры на куче
         MyStruct testStruct = new MyStruct();
         // Запись в поле change
         testClass.change = "не изменено";
         // Запись в поле change
         testStruct.change = "не изменено";

         // Вызов метода ClassTaker и передача в качестве аргумента ссылки на класс
         ClassTaker(testClass);
         // Вызов метода StructTaker и передача в качестве аргумента ссылки на структуру
         StructTaker(testStruct);
         // Отобраджение значения поля change класса
         Console.WriteLine("Поле классса = {0}", testClass.change);
         // Отобраджение значения поля change структуры
         Console.WriteLine("Поле структуры = {0}", testStruct.change);

         Console.ReadKey();
      }
   }
}