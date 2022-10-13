using System;
namespace DictorinaryDS
{
    public class KeyValue<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    public partial class Dictionary<TKey,TValue>
    {
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        private int _count;
        private int _capacity;
        public KeyValue<TKey,TValue> [] Array{get; set;}

        public Dictionary(int size)
    {
        if (size==0)
        {
            _capacity=4;
            _count=0;
            Array=new KeyValue<TKey,TValue>[_capacity];
        }
        else if(size>0)
        {
            _capacity=size*2;
            Array=new KeyValue<TKey,TValue>[_capacity];
        }
    }
     public void Add(TKey key,TValue value)
    {
        if(_capacity==_count)
        {
            Expend();
        }
        bool check=LinearSearch(key, out int index);
        if(check==true)
        {
            System.Console.WriteLine("Duplicate Key");
        }
        KeyValue<TKey,TValue> entry = new KeyValue<TKey,TValue>();
        entry.Key=key;
        entry.Value=value;
        Array[_count]=entry;
        _count++;
    }
    public void Expend()
    {
        _capacity=_capacity*2;
        KeyValue<TKey,TValue> [] temp = new KeyValue<TKey,TValue>[_capacity];
        for (int i=0;i<_count;i++)
        {
            temp[i]=Array[i];
        }
        Array=temp;
    }
    public void Display()
    {
        foreach(KeyValue<TKey,TValue> element in Array)
        {
            if(element!=null)
            {
                System.Console.WriteLine("Key: "+element.Key+"\t"+"Value: "+element.Value);
            }
        }
    }
    public bool LinearSearch(TKey key,out int index)
    {
        bool check = false;
        index=0;
        for (int i=0;i<_count;i++)
        {
            if(key.Equals(Array[i].Key))
            {
                index=i;
                check= true;
                break;
            }
        } 
        return check;
    }
    public TValue this [TKey key] //Indxers
    {
        get
        {
            TValue output = default(TValue);
            int index=0;
            bool check = LinearSearch(key,out index);
            if(check)
            {
                output=Array[index].Value;
            }
            else
            {
                System.Console.WriteLine("Invalid Key");
            }
            return output;
        }
        set
        {
            int position =0;
            bool check = LinearSearch(key, out position);
            if (check)
            {
                Array[position].Value=value;
            }
            else
            {
                System.Console.WriteLine("Invalid Key");
            }
        }
    }
    }
}