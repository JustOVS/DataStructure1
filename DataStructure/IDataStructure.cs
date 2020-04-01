using System;
namespace DataStructure
{
    public interface IDataStructure
    {

      
        public void Add(int[] a);  //5-21 добавление в конец массива

        public void Add(int a);  //5-1 добавление в конец

        public void Remove();   // 5-4 удаление из конца

        public void Remove(int quantity);   // 5-24 удаление из конца

        public void Insert(int item, int index); // 5-3 добавление по индексу

        public void Insert(int[] addmassive, int index); // 5-23 добавление по индексу массива

        public void AddToStart(int item);  //5-2 добавление в начало

        public void AddToStart(int[] item);  //5-22 добавление в начало

        public int[] ReturnMassive();  // 5-10 вернуть массив

        public void RemoveOfIndex(int index); //5-6 удаление по индексe

        public void RemoveOfIndex(int index, int quantity); //5-26 удаление по индексу

        public void RemoveFromStart(); // 5-5 удаление из начала

        public void RemoveFromStart(int quantity); // 5-25 удаление из начала

        public int IndexOfItem(int item); // 5-8 индекс по значению

        public void Reverse();   //5-11 реверс

        public int MinItem();  // 5-13 поиск минимального значения

        public int MaxItem();  // 5-12 поиск максимального значения

        public void SortUp();   // 5-16 сортировка по возрастанию

        public void SortDown(); //5-17 сортировка по убыванию

        public void RemoveItem(int item); //5-18 удаление по значению

        public int MinItemIndex(); //5-15 индекс мин элемента

        public int MaxItemIndex(); //5-14 индекс макс элемента

        public int this[int index] { get; set; }











    }
}
