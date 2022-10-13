namespace StackDS
{
    public partial class Stack<String>
    {
        private String [] Array{get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}

        public Stack()
    {
        _count=0;
        _capacity=4;
        Array=new String[_capacity];
    }
    public Stack(int size)
    {
        _count=0;
        _capacity=size;
        Array=new String[_capacity];
    }

    public void Push(String data)
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
    public String Pop()
    {
        String value = default(String);
        if(_count!=-1)
        {
            System.Console.WriteLine("Popped from stack" +Array[_count]);
            value=Array[_count];
            _count--;
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
    public String Peek()
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


    }
}