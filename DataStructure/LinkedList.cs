using System;
namespace DataStructure
{
    public class LinkedList : IDataStructure
    {
        private Node first;
        private Node last;




        public int Length { get; private set; }

        public LinkedList()
        {
            first = null;
            last = null;
            Length = 0;
        }

        public LinkedList(int a)
        {
            first = new Node(a);
            last = first;
            Length = 1;
        }

        public LinkedList(int[] a)
        {
            for (int i = 0; i< a.Length; i++)
            {
                this.Add(a[i]);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index == Length - 1)
                {
                    return last.Value;
                }
                else if (index == 0)
                {
                    return first.Value; 
                }
                else if (index < 0 || index > Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    return current.Value;
                }


                //int[] array = this.ReturnMassive();
                //return array[index]; //5-7 доступ по индексу
            }

            set
            {
                if (index == Length - 1)
                {
                    last.Value = value;
                }
                else if (index == 0)
                {
                    first.Value = value; // 5-9 изменение по индексу
                }
                else if (index < 0 || index > Length - 1)
                {
                }
                else
                {
                    Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    current.Value = value;
                }
            }
        }

        public void Add(int a)
        {
            if (first == null)
            {
                first = new Node(a);
                last = first;
                Length = 1;
            }
            else
            {
                last.Next = new Node(a);
                last = last.Next;
                Length++;
            }

        }

        public int[] ReturnMassive()
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                int i = 0;
                Node tmp = first;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void AddToStart(int a)
        {
            if (first != null)
            {
                Node tmp = new Node(a);
                tmp.Next = first;
                first = tmp;
                Length++;
            }
            else
            {
                first = new Node(a);
                last = first;
                Length = 1;
            }
        }

        public void AddToStart(int[] item)
        {
            for (int i = item.Length - 1; i >= 0; i--)
            {
                this.AddToStart(item[i]);
            }
        }


        public void Add(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                this.Add(a[i]);
            }
        }


        public void Remove()
        {
            if (first == last)
            {
                first = null;
                last = null;
                Length = 0;
            }
            else if (first == null)
            {

            }
            else
            {
                Node current = first;
                while (current.Next != last)
                {
                    current = current.Next;
                }
                current.Next = null;
                last = current;
                Length--;
            }
        }

        public void Remove(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.Remove();
            }
        }

        public void RemoveFromStart()
        {
            if (first == last)
            {
                first = null;
                last = null;
                Length = 0;
            }
            else if (first == null)
            {

            }
            else
            {
                first = first.Next;
                Length--;
            }
        }

        public void RemoveFromStart(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.RemoveFromStart();
            }
        }

        public void Insert(int item, int index)
        {
            if (index == 0)
            {
                AddToStart(item);
            }

            else if (index < 0 || index > Length)
            {
            }
            else if (index == Length)
            {
                this.Add(item);
            }
            else
            {
                Node tmp = new Node(item);
                Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                tmp.Next = previous.Next;
                previous.Next = tmp;
            
                Length++;
            }
        }

        public void Insert(int[] addmassive, int index)
        {
            for (int i = 0; i < addmassive.Length; i++)
            {
                this.Insert(addmassive[i], index + i);
            }
        }

        public void RemoveOfIndex(int index)
        {
            if (index == 0)
            {
                this.RemoveFromStart();

            }
            else if (index < 0 || index > Length - 1)
            {
            }
            else if (index == Length -1)
            {
                this.Remove();
            }
            else
            {
                Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }

                previous.Next = previous.Next.Next;
                Length--;
            }
        }

        public void RemoveOfIndex(int index, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.RemoveOfIndex(index);
            }
        }



        public int IndexOfItem(int item)
        {
            Node current = first;
            int count = 0;
            while (current != null)
            {
                if (current.Value == item)
                {
                    break;
                }
                count++;
                current = current.Next;
            }
            if (current == null)
            {
                return -1;
            }
            else
            {
                return count;
            }
        }

        public void Reverse()
        {
            Node previous = null;
            Node current = first;
            Node next;
            first = last;
            last = current;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            
        }

        public int MinItem()
        {
            Node current = first;
            int min = current.Value;
            while (current != null)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                }
                current = current.Next;
            }
            
            return min;
        }
        

        public int MaxItem()
        {
        Node current = first;
        int max = current.Value;
        while (current != null)
        {
            if (current.Value > max)
            {
                max = current.Value;
            }
            current = current.Next;
        }

        return max;
        }


        public void SortUp()
        {
            Node tmpListFirst = null;
            Node tmpListLast = null;

            for (int i = 0; i < Length; i++)
            {
                Node current = first;
                Node previous = first;
                Node min = first;
                Node minPrevious = first;
                
                while (current != null)
                {
                    if (current.Value < min.Value)
                    {
                        min = current;
                        minPrevious = previous;
                    }
                    previous = current;
                    current = current.Next;
                }
               
                if (min == first)
                {
                    first = first.Next;
                }
                else if (min == last) 
                {
                    minPrevious.Next = null;
                    last = minPrevious;
                }
                else
                {
                    minPrevious.Next = minPrevious.Next.Next;
                }
                
                if (tmpListFirst != null)
                {
                    tmpListLast.Next = min;
                    tmpListLast = tmpListLast.Next;
                }
                else
                {
                    tmpListFirst = min;
                    tmpListLast = tmpListFirst;
                }
            }
            first = tmpListFirst;
            last = tmpListLast;
        }




    

        public void SortDown()
        {
            Node tmpListFirst = null;
            Node tmpListLast = null;

            for (int i = 0; i < Length; i++)
            {
                Node current = first;
                Node previous = first;
                Node max = first;
                Node maxPrevious = first;

                while (current != null)
                {
                    if (current.Value > max.Value)
                    {
                        max = current;
                        maxPrevious = previous;
                    }
                    previous = current;
                    current = current.Next;
                }

                if (max == first)
                {
                    first = first.Next;
                }
                else if (max == last)
                {
                    maxPrevious.Next = null;
                    last = maxPrevious;
                }
                else
                {
                    maxPrevious.Next = maxPrevious.Next.Next;
                }

                if (tmpListFirst != null)
                {
                    tmpListLast.Next = max;
                    tmpListLast = tmpListLast.Next;
                }
                else
                {
                    tmpListFirst = max;
                    tmpListLast = tmpListFirst;
                }
            }
            first = tmpListFirst;
            last = tmpListLast;
        }

        public void RemoveItem(int item)
        { 
            Node previous = null;
            Node current = first;

            while (current != null)
            {
                if (current.Value == item && previous == null)
                {
                    first = current.Next;
                    Length--;
                }
                else if ( current.Value == item)
                {
                    previous.Next = current.Next;
                    Length--;
                }
                else
                {
                    previous = current;
                }
                current = current.Next;

            }

        }

        public int MinItemIndex()
        {
            Node current = first;
            int min = current.Value;
            int count = 0;
            int minIndex = 0;
            while (current != null)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                    minIndex = count;
                }
                current = current.Next;
                count++;
            }

            return minIndex;
        }

        public int MaxItemIndex()
        {
            Node current = first;
            int max = current.Value;
            int count = 0;
            int maxIndex = 0;
            while (current != null)
            {
                if (current.Value > max)
                {
                    max = current.Value;
                    maxIndex = count;
                }
                current = current.Next;
                count++;
            }

            return maxIndex;
        }
    }

}
