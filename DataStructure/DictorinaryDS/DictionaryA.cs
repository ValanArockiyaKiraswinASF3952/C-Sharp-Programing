using System;
namespace DictorinaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
            bool check = false;
        
        for (int i=0;i<_count;i++)
        {
            if(key.Equals(Array[i].Key))
            {
                check= true;
                break;
            }
        } 
        return check;
        }

        public bool ContainsValue(TValue value)
        {
            bool check = false;
        for (int i=0;i<_count;i++)
        {
            if(value.Equals(Array[i].Value))
            {
                check= true;
                break;
            }
        } 
        return check;
        }

        public KeyValue<TKey,TValue> ElementAt(int index)
        {
            KeyValue<TKey,TValue> output = null;
            if(Count>index && index>-1)
            {
                output=Array[index];
            }
            else
            {
                System.Console.WriteLine("Tried to access aout of bound");
            }
            return output;
        }
        public bool Remove(TKey key)
        {
            int index =0;
            bool check = LinearSearch(key,out index);
            if(check==true)
            {
                for(int i=0;i<Count;i++)
                {
                    Array[index]=Array[index+1];
                }
                check=true;
            }
            else
            {
                //Array[index]=Array[index];
                check = false;
            }
            return check;
        }
    }
}