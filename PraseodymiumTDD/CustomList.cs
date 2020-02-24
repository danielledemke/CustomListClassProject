using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraseodymiumTDD
{
    public class CustomList<T>
    {
        private T[] array;
        private int count;
        private int capacity = 4;
        
        public T this[int number]
        {
            get
            {
                if(number < 0 || number >= array.Length)
                {
                    Console.WriteLine("Index out of range");
                }
                return T[number];
            }
            set
            {
                if (number < 0 || number >= array.Length)
                {
                    Console.WriteLine("Index out of range");
                }
                T[number] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public CustomList()
        {
            array = new T[capacity];
        }

        public void Add(T item)
        {
            IncrementCount(); //increment list by one

            InsertAtAvailableIndex(item); //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
        }
        public void IncrementCount()
        {
            count++;
        }

        public void InsertAtAvailableIndex(T item)
        {              
          array[count] = item;
            
        }

        public void IncreaseCapacity()
        {
            if(count > capacity)
            {
                capacity *= 2;
                T[] newArray = new T[capacity]();
                newArray = array;

            }
            
            




        }
    }
}
