using NUnit.Framework;
using DataStructure;

namespace DataStructureTest
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]



    public class Tests
    {
        int a;

        IDataStructure testList;

        public Tests(int Q)
        {
            a = Q;
        }
        [SetUp]
        public void CreateObject()
        {
            switch (a)
            {
                case 1: testList = new ArrayList();
                    break;
                case 2: testList = new LinkedList();
                    break;
                case 3: testList = new L2List();
                    break;

            }
        }




        [TestCase(4, new int[] { 1, 3, 2 }, ExpectedResult = new int[] {1, 3, 2, 4 })]
        [TestCase(3, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1, 5, 3 })]
        [TestCase(15, new int[] { 1 }, ExpectedResult = new int[] { 1, 15 })]
        public int[] AddTest(int item, int[] massive)
        {
            testList.Add(massive);
           
            testList.Add(item);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 3, 2, 4, 5 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, new int[] { 9 }, ExpectedResult = new int[] { 8, 0, 1, 5, 9 })]
        [TestCase(new int[] { 1 }, new int[] { }, ExpectedResult = new int[] { 1 })]
        public int[] AddTest(int[] massive, int[] addmassive)
        {
            testList.Add(massive);
            testList.Add(addmassive);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1})]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[0] { })]
        public int[] RemoveTest(int[] massive)
        {
            testList.Add(massive);
            testList.Remove();
            return testList.ReturnMassive();
        }

        [TestCase(2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1 })]
        [TestCase(3, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8 })]
        [TestCase(1, new int[] { 1 }, ExpectedResult = new int[0] { })]
        public int[] RemoveTest(int quantity, int[] massive)
        {
            testList.Add(massive);
            testList.Remove(quantity);
            return testList.ReturnMassive();
        }

        [TestCase(4, 2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3, 4, 2 })]
        [TestCase(3, 0, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 3, 8, 0, 1, 5 })]
        [TestCase(15, 1, new int[] { 1 }, ExpectedResult = new int[] { 1, 15 })]
        public int[] InsertTest(int item, int index, int[] massive)
        {
            testList.Add(massive);
            testList.Insert(item, index);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3, 1, 2, 3, 4, 2 })]
        [TestCase(new int[] { }, 3, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1, 5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 3, 3, 3 }, ExpectedResult = new int[] { 3, 1, 3, 3 })]
        public int[] InsertTest(int[] addmassive, int index, int[] massive)
        {
            testList.Add(massive);
            testList.Insert(addmassive, index);
            return testList.ReturnMassive();
        }

        [TestCase(4, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 4, 1, 3, 2})]
        [TestCase(3, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 3, 8, 0, 1, 5 })]
        [TestCase(15, new int[] { 1 }, ExpectedResult = new int[] { 15, 1 })]
        public int[] AddToStartTest(int item, int[] massive)
        {
            testList.Add(massive);
            testList.AddToStart(item);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 2, 3, 4, 1, 3, 2 })]
        [TestCase(new int[] { }, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1, 5 })]
        [TestCase(new int[] { 1 }, new int[] { 3, 3, 3 }, ExpectedResult = new int[] { 1, 3, 3, 3 })]
        public int[] AddToStartTest(int[] addmassive, int[] massive)
        {
            testList.Add(massive);
            testList.AddToStart(addmassive);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3, 2})]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1, 5})]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { 1 })]
        public int[] ReturnMassiveTest(int[] massive)
        {
            testList.Add(massive);
            return testList.ReturnMassive();
        }

        [TestCase(2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3})]
        [TestCase(1, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 1, 5})]
        [TestCase(0, new int[] { 1 }, ExpectedResult = new int[] { })]
        public int[] RemoveOfIndexTest(int index, int[] massive)
        {
            testList.Add(massive);
            testList.RemoveOfIndex(index);
            return testList.ReturnMassive();
        }

        [TestCase(1, 2, new int[] { 1, 3, 2, 4}, ExpectedResult = new int[] { 1, 4 })]
        [TestCase(2, 3, new int[] { 8, 0, 1, 5, 6, 7 }, ExpectedResult = new int[] { 8, 0, 7 })]
        [TestCase(0, 2, new int[] { 1, 2 }, ExpectedResult = new int[] { })]
        public int[] RemoveOfIndexTest(int index, int quantity, int[] massive)
        {
            testList.Add(massive);
            testList.RemoveOfIndex(index, quantity);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 3, 2 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 0, 1, 5 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
        public int[] RemoveFromStartTest(int[] massive)
        {
            testList.Add(massive);
            testList.RemoveFromStart();
            return testList.ReturnMassive();
        }

        [TestCase(2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 2 })]
        [TestCase(2, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 1, 5 })]
        [TestCase(1, new int[] { 1 }, ExpectedResult = new int[] { })]
        public int[] RemoveFromStartTest(int quantity, int[] massive)
        {
            testList.Add(massive);
            testList.RemoveFromStart(quantity);
            return testList.ReturnMassive();
        }

        [TestCase(2, new int[] { 1, 3, 2 }, ExpectedResult = 2)]
        [TestCase(5, new int[] { 8, 0, 1, 5 }, ExpectedResult = 3)]
        [TestCase(1, new int[] { 1 }, ExpectedResult = 0)]
        public int IndexOfItemTest(int item, int[] massive)
        {
            testList.Add(massive);
            return testList.IndexOfItem(item);
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] {2, 3, 1 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 5, 1, 0, 8 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { 1 })]
        public int[] ReverseTest(int[] massive)
        {
            testList.Add(massive);
            testList.Reverse();
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = 1)]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        public int MinItemTest(int[] massive)
        {
            testList.Add(massive);
            return testList.MinItem();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = 3)]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = 8)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        public int MaxItemTest(int[] massive)
        {
            testList.Add(massive);
            return testList.MaxItem();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 0, 1, 5, 8 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { 1 })]
        public int[] SortUpTest(int[] massive)
        {
            testList.Add(massive);
            testList.SortUp();
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 5, 1, 0 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { 1 })]
        public int[] SortDownTest(int[] massive)
        {
            testList.Add(massive);
            testList.SortDown();
            return testList.ReturnMassive();
        }

        [TestCase(2, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 3 })]
        [TestCase(1, new int[] { 8, 1, 1, 5 }, ExpectedResult = new int[] { 8, 5 })]
        [TestCase(1, new int[] { 1 }, ExpectedResult = new int[] {  })]
        public int[] RemoveItemTest(int item, int[] massive)
        {
            testList.Add(massive);
            testList.RemoveItem(item);
            return testList.ReturnMassive();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = 0)]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1 }, ExpectedResult = 0)]
        public int MinItemIndexTest(int[] massive)
        {
            testList.Add(massive);
            return testList.MinItemIndex();
        }

        [TestCase(new int[] { 1, 3, 2 }, ExpectedResult = 1)]
        [TestCase(new int[] { 8, 0, 1, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, ExpectedResult = 0)]
        public int MaxItemIndexTest(int[] massive)
        {
            testList.Add(massive);
            return testList.MaxItemIndex();
        }

        [TestCase(1, new int[] { 1, 3, 2 }, ExpectedResult = 3)]
        [TestCase(3, new int[] { 8, 0, 1, 5 }, ExpectedResult = 5)]
        [TestCase(0, new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(4, new int[] { 5, 3, 8, 4, 9, 10, 45}, ExpectedResult = 9)]
        public int GetIndexatorTest(int index, int[] massive)
        {
            testList.Add(massive);

            return testList[index];
        }

        [TestCase(1, 5, new int[] { 1, 3, 2 }, ExpectedResult = new int[] { 1, 5, 2 })]
        [TestCase(3, 7, new int[] { 8, 0, 1, 5 }, ExpectedResult = new int[] { 8, 0, 1, 7 })]
        [TestCase(0, 5, new int[] { 1 }, ExpectedResult = new int[] { 5 })]
        [TestCase(4, 7, new int[] { 5, 3, 8, 4, 9, 10, 45 }, ExpectedResult = new int[] { 5, 3, 8, 4, 7, 10, 45 })]
        public int[] SetIndexatorTest(int index,int value, int[] massive)
        {
            testList.Add(massive);
            testList[index] = value;

            return testList.ReturnMassive();
        }
    }
}