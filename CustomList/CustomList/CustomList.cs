using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{

    public class CustomList<T>
    {
        public T[] customListArray = new T[1];
        private int count = 0;
        private int capacity = 1;

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> subtractedList = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)         
                {
                    bool removalMatchFound = false;
                    for(int j = 0; j < list2.Count; j++)    //check for matches on list2, if a match is found for this index, do not add to the output list
                    {
                        if (list1.customListArray[i].Equals(list2.customListArray[j]))
                        {
                            removalMatchFound = true;
                        }
                    }
                    if (removalMatchFound == false)
                    {
                    subtractedList.Add(list1.customListArray[i]);
                    }
                }
            return subtractedList;
            

        }

        public static CustomList<T> operator +(CustomList<T> list1,CustomList<T> list2){
            int combinedListBucketCapacity = list1.Capacity + list2.Capacity;
            int combinedListCount = list1.Count + list2.Count;
            T[] combinedArray = new T[combinedListBucketCapacity];
            int combinedArrayIndex = 0;
            if (combinedListCount == 0)
            {
                //lists are empty;
            }
            for(int i = 0; i < list1.Count; i++)
                {
                    combinedArray[combinedArrayIndex] = list1.customListArray[i];
                    combinedArrayIndex++;
                }
            for(int i = 0; i < list2.Count; i++)
                {
                    combinedArray[combinedArrayIndex] = list2.customListArray[i];
                    combinedArrayIndex++;
                }
            CustomList<T> outPutList = new CustomList<T>();
            outPutList.capacity=combinedListBucketCapacity;
            outPutList.count = combinedListCount;
            outPutList.customListArray = combinedArray;
            return outPutList;
            }
            
        public void Add(T item)
        {
            int arrayBucketCapacity = count + 1;                //we are adding a new entry so make a temp array with enough room for it and all previous entries
            T[] arrayBucket = new T[arrayBucketCapacity];       //make the temp array
            if (count > 0)                                        //if this isn't the first entry to the list
            {
                for (int i = 0; i < arrayBucketCapacity-1; i++)     //for as many entries as currently exist, copy those entries into the new array
                {
                    arrayBucket[i] = customListArray[i];
                }
            }
            arrayBucket[count] = item;            //place the newest entry into the temp array
            count++;                                //increase the count
            capacity = count;
            customListArray = new T[count];     //now pour the bucket into our new customListArray
            for (int i = 0; i < count; i++)
                {
                    customListArray[i] = arrayBucket[i];
                }
        }
        public void Remove(T item)
        {
            bool foundTarget = false;
            int arrayBucketCapacity = count;//we wont modify this until after we have found something to remove
            T[] arrayBucket = new T[arrayBucketCapacity];
            int bucketIndex = 0;
            for (int i = 0; i< count; i++)
            {
                if (customListArray[i].Equals(item) && foundTarget==false)
                {
                    foundTarget = true;
                    bucketIndex -= 1;
                }
                else
                {
                    arrayBucket[bucketIndex] = customListArray[i];
                }
                bucketIndex += 1;
            }
            if (foundTarget == true)//we did successfully remove a value so lets be consistent with capacity
            {
                count = count - 1;
                capacity = count;
            }
            customListArray = new T[count];     //now pour the bucket into our new customListArray
            for (int i = 0; i < count; i++)
            {
                customListArray[i] = arrayBucket[i];
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

    }
}
