using System;
namespace DataStructure
{
    public class L2List : IDataStructure
    {


        private L2Node first;
        private L2Node last;
        public int Length { get; private set; }

        public L2List()
        {
            first = null;
            last = null;
            Length = 0;
        }

        public L2List(int a)
        {
            first = new L2Node(a);
            last = first;
            Length = 1;
        }

        public L2List(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
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
                else if (index <= Length/2)
                {
                    L2Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    return current.Value;
                }
                else
                {
                    L2Node current = last;

                    for (int i = 0; i < Length - 1 - index; i++)
                    {
                        current = current.Previous;
                    }

                    return current.Value;
                }


                
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
                else if (index <= Length / 2)
                {
                    L2Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    current.Value = value;
                }
                else
                {
                    L2Node current = last;

                    for (int i = 0; i < Length - 1 - index; i++)
                    {
                        current = current.Previous;
                    }

                    current.Value = value;
                }
            }
        }

        public void Add(int a)
        {
            if (first == null)
            {
                first = new L2Node(a);
                last = first;
                Length = 1;
            }
            else
            {
                last.Next = new L2Node(a);
                last.Next.Previous = last;
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
                L2Node tmp = first;
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
                first.Previous = new L2Node(a);
                first.Previous.Next = first;
                first = first.Previous;
                Length++;
            }
            else
            {
                first = new L2Node(a);
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
                last.Previous.Next = null;
                last = last.Previous;
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
                first.Previous = null;
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
            else if (index <= Length / 2)
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                tmp.Next = previous.Next;
                previous.Next.Previous = tmp;
                previous.Next = tmp;
                tmp.Previous = tmp;

                Length++;
            }
            else
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }
                tmp.Next = previous.Next;
                previous.Next.Previous = tmp;
                previous.Next = tmp;
                tmp.Previous = tmp;

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
            else if (index == Length - 1)
            {
                this.Remove();
            }
            else if (index <= Length/2)
            {
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }

                previous.Next = previous.Next.Next;
                previous.Next.Previous = previous;
                Length--;
            }
            else
            {
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }

                previous.Next = previous.Next.Next;
                previous.Next.Previous = previous;
                Length--;
            }
        }

        public void RemoveOfIndex(int index, int quantity)
        {
            //for (int i = 0; i < quantity; i++)
            //{
            //    this.RemoveOfIndex(index);
            //}
            if (index == 0)
            {
                this.RemoveFromStart(quantity);

            }
            else if (index < 0 || index > Length - 1)
            {
            }
            else if (index == Length - quantity)
            {
                this.Remove(quantity);
            }
            else if (index <= Length / 2)
            {
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                L2Node next = previous;
                for (int i = 0; i <= quantity; i++)
                {
                    next = next.Next;
                }
                previous.Next = next;
                next.Previous = previous;
                Length-= quantity;
            }
            else
            {
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }
                L2Node next = previous;
                for (int i = 0; i <= quantity; i++)
                {
                    next = next.Next;
                }
                previous.Next = next;
                next.Previous = previous;
                Length -= quantity;
            }
        }



        public int IndexOfItem(int item)
        {
            L2Node current = first;
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
            L2Node current = first;
            L2Node tmp = first;
            first = last;
            last = current;

            while (current != null)
            {
                tmp = current.Next;
                current.Next = current.Previous;
                current.Previous = tmp;
                current = tmp;
            }

        }

        public int MinItem()
        {
            L2Node current = first;
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
            L2Node current = first;
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
            L2Node tmpListFirst = null;
            L2Node tmpListLast = null;

            for (int i = 0; i < Length; i++)
            {
                L2Node current = first;
                L2Node min = first;


                while (current != null)
                {
                    if (current.Value < min.Value)
                    {
                        min = current;
                    }
                    current = current.Next;
                }
                if (first == last)
                {
                    first = null;
                    last = null;
                }
                else if (min == first)
                {
                    first.Next.Previous = null;
                    first = first.Next;

                }
                else if (min == last)
                {
                    last.Previous.Next = null;
                    last = last.Previous;
                }
                else
                {
                    min.Previous.Next = min.Next;
                    min.Next.Previous = min.Previous;
                }

                if (tmpListFirst != null)
                {
                    tmpListLast.Next = min;
                    min.Previous = tmpListLast;
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
            L2Node tmpListFirst = null;
            L2Node tmpListLast = null;

            for (int i = 0; i < Length; i++)
            {
                L2Node current = first;
                L2Node max = first;


                while (current != null)
                {
                    if (current.Value > max.Value)
                    {
                        max = current;
                    }
                    current = current.Next;
                }
                if (first == last)
                {
                    first = null;
                    last = null;
                }
                else if (max == first)
                {
                    first.Next.Previous = null;
                    first = first.Next;

                }
                else if (max == last)
                {
                    last.Previous.Next = null;
                    last = last.Previous;
                }
                else
                {
                    max.Previous.Next = max.Next;
                    max.Next.Previous = max.Previous;
                }

                if (tmpListFirst != null)
                {
                    tmpListLast.Next = max;
                    max.Previous = tmpListLast;
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
            
            L2Node current = first;

            while (current != null)
            {
                if (current.Value == item && first == last)
                {
                    first = null;
                    last = null;
                    Length--;
                }
                else if (current.Value == item && current.Previous == null)
                {
                    current.Next.Previous = null;
                    first = current.Next;
                    Length--;
                }
                else if (current.Value == item && current.Next == null)
                {
                    current.Previous.Next = null;
                    last = current.Previous;
                    Length--;
                }
                else if (current.Value == item)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Length--;
                }
                
                current = current.Next;

            }

        }

        public int MinItemIndex()
        {
            L2Node current = first;
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
            L2Node current = first;
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

