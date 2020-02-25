using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T>
    {
        private T[] array;
        private int count;
        private int capacity = 4;
        
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                array[index] = value;
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
            IncreaseCapacity(); //count == maxcapacity, we need to increase capacity and copy
            InsertAtAvailableIndex(item); //item needs to land at next available index
            IncrementCount(); //increment list by one    
            
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
            if (count >= capacity)
            {
                capacity *= 2;
                T[] newArray = new T[capacity];

                for(int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                
                array = newArray;

            }
        }


        public void Remove(T item)
        {
            //decrease count
            //need to find item and remove item from array
            //need to shift other items down the index
        }
    }
}
