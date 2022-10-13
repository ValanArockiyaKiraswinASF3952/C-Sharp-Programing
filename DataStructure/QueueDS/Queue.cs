namespace QueueDS
{
    public partial class Queue<String>
    {
        private String [] Array{get; set;}
        private int _count;
        private int _capacity;
        private int _head;
        private int _tail;
        private int _version;

        public int Count{get{return _count;}}
        // public int Capacity{get{return _capacity;}}
        // public int Head{get{return _head;}}
        // public int Tail{get{return _tail;}}
        // public int Version{get{return _version;}}

        public Queue()
    {
        _count=0;
        _capacity=4;
        _head=0;
        _tail=0;
        _version=0;
        Array=new String[_capacity];
    }
    public Queue(int size)
    {
        _count=0;
        _capacity=size;
        _head=0;
        _tail=0;
        _version=0;
        Array=new String[_capacity];
    }
    public void Enqueue(String data)
    {
        
        if(_count==_capacity)
        {
            //
            GrowSize();
        }
        Array[_count]=data;
        _count++;
    }
    public void GrowSize()
    {
        _capacity=_capacity*2;
        String[] temp = new String[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=Array[i];
        }
        Array=temp;
    }
    public String Dequeue()
    {
        String value = default(String);
        if(_head>_count)
        {
            System.Console.WriteLine("Empty Queue");
        }
        else 
        {
            value=Array[_head];
            _head++;
            _count--;
        }
        return value;
    }
    public String peek()
    {
         String value = default(String);
        if(_count!=-1)
        {
            System.Console.WriteLine("Popped from stack" +Array[_count]);
            value=Array[_count];
            
        }
        else if(_count>0)
        {
            System.Console.WriteLine("Stack is empty");
        }
        return value;
    }
    public bool Contains(String data)
    {
        
        for (int i=0;i<_count;i++)
        {
            if(Array.Equals(data))
            {
                return true;
            }
        }
        return false;
    }

    }
}