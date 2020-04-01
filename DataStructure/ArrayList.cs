using System;
namespace DataStructure
{
    public class ArrayList : IDataStructure
    {
        private int[] array;
        private int length { get; set; }

        public int Length { get { return length; } private set { } }//5-19 вернуть длину

        public ArrayList() //5-20
        {
            array = new int[0];
            length = 0;
        }

        public ArrayList(int item)
        {
            array = new int[] { item };
            length = 1;
        }

        public ArrayList(int[] a) 
        {
            length = a.Length;
            array = a;
        }

        private void UpArraySize()
        {
            int newL = Convert.ToInt32(array.Length * 1.3 + 1);
            int[] newArray = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        private void DownArraySize()
        {
            int newL = Convert.ToInt32(array.Length * 0.75 + 1);
            int[] newArray = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void Add(int[] a)  //5-21 добавление в конец массива
        {
            for (int i = 0; i < a.Length; i++)
            {
                this.Add(a[i]);
            }


        }

        public void Add(int a)  //5-1 добавление в конец
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }


            array[length] = a;
            length++;


        }

        public void Remove()   // 5-4 удаление из конца
        {
            if (length < 0.75 * array.Length)
            {
                DownArraySize();
            }
            length--;


        }

        public void Remove(int quantity)   // 5-24 удаление из конца
        {
            for(int i = 0; i < quantity; i++)
            {
                this.Remove();
            }
        }



        public int this[int index] 
        {
            get
            {
                return array[index]; //5-7 доступ по индексу
            }

            set
            {
                array[index] = value; // 5-9 изменение по индексу
            }
        }

        public void Insert(int item, int index) // 5-3 добавление по индексу
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            for (int i = length; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
            length++;
        }

        public void Insert(int[] addmassive, int index) // 5-23 добавление по индексу массива
        {
            for (int i = 0; i < addmassive.Length; i++)
            {
                this.Insert(addmassive[i], index + i);
            }

        }
        public void AddToStart(int item)  //5-2 добавление в начало
        {
            this.Insert(item, 0);
        }

        public void AddToStart(int[] item)  //5-22 добавление в начало
        {
            this.Insert(item, 0);
        }

        public int[] ReturnMassive()  // 5-10 вернуть массив
        {
            int[] massive = new int[length];
            for (int i = 0; i < length; i++)
            {
                massive[i] = array[i];
            }
            return massive;
        }
        public void RemoveOfIndex(int index) //5-6 удаление по индексу
        {
            if (length < 0.75 * array.Length)
            {
                DownArraySize();
            }
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
        }

        public void RemoveOfIndex(int index, int quantity) //5-26 удаление по индексу
        {
            for(int i = 0; i < quantity; i++)
            {
                this.RemoveOfIndex(index);
            }
        }

        public void RemoveFromStart() // 5-5 удаление из начала
        {
            this.RemoveOfIndex(0);
        }

        public void RemoveFromStart(int quantity) // 5-25 удаление из начала
        {
            this.RemoveOfIndex(0, quantity);
        }

        public int IndexOfItem(int item) // 5-8 индекс по значению
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }

            }
            return -1;
        }
        public void Reverse()   //5-11 реверс
        {
            for (int i = 0; i < length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = tmp;
            }

        }

        public int MinItem()  // 5-13 поиск минимального значения
        {
            int min = array[0];

            for (int i = 1; i < length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }


        public int MaxItem()  // 5-12 поиск максимального значения
        {
            int max = array[0];

            for (int i = 1; i < length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public void SortUp()   // 5-16 сортировка по возрастанию
        {
            for (int i = 1; i < length; i++)
            {
                for (int j = i - 1; j >= 0 && array[j] > array[j + 1]; j--)
                {
                    int tmp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = tmp;
                }
            }

        }

        public void SortDown() //5-17 сортировка по убыванию
        {
            for (int i = 0; i < length - 1; i++)
            {

                for (int j = 1; j < length - i; j++)        
                {
                    if (array[j] > array[j - 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }

        }
        public void RemoveItem(int item) //5-18 удаление по значению
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (array[i] == item)
                {
                    this.RemoveOfIndex(i);
                }

            }
        }
        public int MinItemIndex() //5-15 индекс мин элемента
        {
            return this.IndexOfItem(this.MinItem());
        }

        public int MaxItemIndex() //5-14 индекс макс элемента
        {
            return this.IndexOfItem(this.MaxItem());
        }


    }
}
