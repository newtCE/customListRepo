using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
                    for(int j = 0; j < list2.Count; j++)
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
        public static CustomList<T> operator +(CustomList<T> list1,CustomList<T> list2)
        {
            int combinedListBucketCapacity = list1.Capacity + list2.Capacity;
            int combinedListCount = list1.Count + list2.Count;
            T[] combinedArray = new T[combinedListBucketCapacity];
            int combinedArrayIndex = 0;
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
            CustomList<T> outPutList = new CustomList<T>
            {
                capacity = combinedListBucketCapacity,
                count = combinedListCount,
                customListArray = combinedArray
            };
            return outPutList;
            }
        public override string ToString()
        {
            StringBuilder arrayString = new StringBuilder();
            for(int i = 0; i < Count; i++)
            {
                if (i==0)
                {
                    arrayString.Append(customListArray[i]);
                }
                else
                {
                    arrayString.Append(", "+customListArray[i]);
                }
            }
            return arrayString.ToString();
        }
        public static CustomList<T> ZipperMerge(CustomList<T> list1, CustomList<T> list2)
        {
            int totalCount = list1.Count + list2.Count;
            CustomList<T> zipperList = new CustomList<T>();
            for(int i = 0; i < totalCount; i++)
            {
                if (i < list1.Count)
                {
                    zipperList.Add(list1.customListArray[i]);
                }
                if (i < list2.Count)
                {
                    zipperList.Add(list2.customListArray[i]);
                }
            }
            return zipperList;
        }
        public void Add(T item)
        {
            int arrayBucketCapacity = count + 1;
            T[] arrayBucket = new T[arrayBucketCapacity];
            if (count > 0)
            {
                for (int i = 0; i < arrayBucketCapacity-1; i++)
                {
                    arrayBucket[i] = customListArray[i];
                }
            }
            arrayBucket[count] = item;
            count++;
            capacity = count;
            customListArray = new T[count];
            for (int i = 0; i < count; i++)
                {
                    customListArray[i] = arrayBucket[i];
                }
        }
        public void Remove(T item)
        {
            bool foundTarget = false;
            int arrayBucketCapacity = count;
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
            if (foundTarget == true)
            {
                count = count - 1;
                capacity = count;
            }
            customListArray = new T[count];
            for (int i = 0; i < count; i++)
            {
                customListArray[i] = arrayBucket[i];
            }

        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return customListArray[i];
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
        // Indexer
        public T this[int index]
        {
            get
            {
                return customListArray[index];
            }

        }

    }
}
