using System;

namespace Structure_12
{
   public static class MyClass
   {
      // Статический метод сортировки массива по номерам поездов
      public static void Sort(Train[] trains)
      {
         for (int i = 0; i < trains.Length; i++)
         {
            for (int q = 0; q < trains.Length; q++)
            {
               if (trains[i].Nomer <= trains[q].Nomer)
               {
                  Train g = trains[i];
                  trains[i] = trains[q];
                  trains[q] = g;
               }
            }
         }
      }

      // Статический метод поиска указаной записи в массиве по ключу (номер поезда)
      public static void Search(Train[] train, int poisk)
      {
         // Создание переменной логического типа
         bool ok = false;
         // Проход по всем элементам массива
         for (int i = 0; i < train.Length; i++)
         {
            // Проверка, эсть запись в массиве с таким номером поезда или нет
            if (train[i].Nomer == poisk)
            {
               Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ",
                  train[i].Nomer, train[i].Punkt, train[i].Time);
               // При успешном нахождении записи, ставим "флаг"
               ok = true;
            }
         }

         // Если такой записи нету "флаг" останется false и выполнится следуйщий код
         if (!ok)
         {
            Console.WriteLine("Поезд не найден!");
         }
      }

      // Статический метод добавления новой записи в массив
      public static void AddingAnArray(Train[] train)
      {
         for (int i = 0; i < train.Length; i++)
         {
            Console.Write("Введите пункт назначения поезда:");
            // Считывание значения с клавиатуры
            string punkt = Console.ReadLine();
            // Запись в поле с помощью тернарного оператора
            punkt = string.IsNullOrEmpty(punkt) ? "Не указан пункт назначения" : punkt;

            Console.Write("Введите номер поезда:");
            string d = Console.ReadLine();
            int nomer = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

            Console.Write("Введите дату отправления:");
            d = Console.ReadLine();
            DateTime date = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);
            // Создание нового екземпляра класса Train и присвоение ссылки на него в массив train
            train[i] = new Train(punkt, nomer, date);
         }
      }

      // Статический метод отображения значений полей
      public static void Show(Train[] train)
      {
         for (int i = 0; i < train.Length; i++)
         {
            Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2}", train[i].Nomer,
               train[i].Punkt, train[i].Time);
         }
      }
   }
}