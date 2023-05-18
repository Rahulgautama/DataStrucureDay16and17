using System;

namespace DataStructureDay16And17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "pravin Choudhary", "Chaitra", "Rahul Gautam", "Name Another" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}
