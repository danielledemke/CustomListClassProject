using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T> : IEnumerable
    {
        private T[] array;
        private int count;
        private int capacity = 4;
        private bool removed;
        
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
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
        public bool Removed
        {
            get
            {
                return removed;
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

                for(int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }

        public void Remove(T item)
        {
           FindItemToRemove(item); //need to find item and remove item from array
            DecreaseCount(); //decrease count
                             //need to shift other items down the index
        }
        public void DecreaseCount()
        {
            if(removed == true)
            {
                count--;
            }
        }
        public void FindItemToRemove(T item)
        {
            int j = 0;
            T[] newArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item) && removed == false)
                {
                    removed = true;
                }
                else
                {
                    newArray[j] = array[i];
                    j++;
                } 
            }
            array = newArray;
        }
        public override string ToString()
        {
            string value = "";
            
                for(int i = 0; i < count; i++)
                {
                value += array[i].ToString() + " ";
                }
            return value;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> item1, CustomList<T> item2)
        {
             CustomList<T> combined = new CustomList<T>();
           
            for (int i = 0; i < item1.count; i++)
            {
                combined.Add(item1[i]);
            }
            for (int i = 0; i < item2.count; i++)
            {
                combined.Add(item2[i]);
            }
            return combined;
        }
        public static CustomList<T> operator -(CustomList<T> item1, CustomList<T> item2)
        {
            CustomList<T> answer = new CustomList<T>();
            
            for(int i = 0; i < item1.count; i++)
            {
                answer.Add(item1[i]);
            }
            for(int i = 0; i < answer.count; i++)
            {
                answer.Remove(item2[i]);
            }

            return answer;
        }

        public CustomList<T> Zip(CustomList<T> item1, CustomList<T> item2)
        {
            CustomList<T> answer = new CustomList<T>();
            int totalCount = item1.count + item2.count;

            for(int i = 0; i < count; i++)
            {
                answer.Add(item1[i]);
                answer.Add(item2[i]);
            }
            return answer;

        }





    }
}
