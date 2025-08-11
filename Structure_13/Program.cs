using System;

namespace Structure_13
{
   internal class Program
   {
      static void Main()
      {
         // Создание экземпляра класса
         MyClass testClass = new MyClass();
         // Создание структуры на куче
         MyStruct testStruct = new MyStruct();
         // Запись в поле change
         testClass.Change = "не изменено";
         // Запись в поле change
         testStruct.Change = "не изменено";

         // Вызов метода ClassTaker и передача в качестве аргумента ссылки на класс
         ClassTaker(testClass);
         // Вызов метода StructTaker и передача в качестве аргумента ссылки на структуру
         StructTaker(testStruct);
         // Отобраджение значения поля change класса
         Console.WriteLine("Поле классса = {0}", testClass.Change);
         // Отобраджение значения поля change структуры
         Console.WriteLine("Поле структуры = {0}", testStruct.Change);

         Console.ReadKey();
      }

      // Статический метод для внесения изменений в поле класса change
      static void ClassTaker(MyClass c)
      {
         c.Change = "изменено";
      }

      // Статический метод для внесения изменений в поле структуры change
      static void StructTaker(MyStruct s)
      {
         s.Change = "изменено";
      }
   }
}