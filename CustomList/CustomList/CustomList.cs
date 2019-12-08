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
        private int count=0;
        

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

    }
}
