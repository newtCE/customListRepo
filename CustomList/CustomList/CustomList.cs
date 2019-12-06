using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    
    public class CustomList<T>
    {
        public T[] customListArray = new T[4];
        private int count=-1;
        List<string> tester = new List<string>();
        

        public void Add(T item)
        {
            int arrayBucketCapacity = count + 2;    //we are adding a new entry so make a temp array with enough room for it and all previous entries
            T[] arrayBucket = new T[arrayBucketCapacity];       //make the temp array
            for (int i = 0; i < count + 1; i++)     //for as many entries as currently exist, copy those entries into the new array
                {
                    arrayBucket[i] = customListArray[i];
                }
            arrayBucket[count+1] = item;            //place the newest entry into the temp array
            count++;                                //increase the count
            customListArray = new T[count + 1];     //now pour the bucket into our new customListArray
            for (int i = 0; i < count + 1; i++)
                {
                    customListArray[i] = arrayBucket[i];
                }
        }
        public void Remove(T item)
        {
            bool foundTarget = false;
            int arrayBucketCapacity = count;//currently set to count as count is in this case always one less than capacity
            T[] arrayBucket = new T[arrayBucketCapacity];
            for (int i = 0; i< count + 1; i++)
            {
                if (customListArray.Equals(item) && foundTarget==false)
                {
                    foundTarget = true;
                }
                else
                {
                    arrayBucket[i] = customListArray[i];
                }
            }
            if (foundTarget == true)//we did successfully remove a value so lets be consistent with capacity
            {
                count = count - 1;
            }
            customListArray = new T[count + 1];     //now pour the bucket into our new customListArray
            for (int i = 0; i < count + 1; i++)
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
