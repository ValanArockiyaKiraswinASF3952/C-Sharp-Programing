namespace ArrayArrayListDS
{
    public class ArrayList
    {
        private dynamic [] Array{get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}

        //Indexer
        public dynamic this[int i]//INDEXER
       {
           get{return Array[i];}
           set{Array[i]=value;}
        }

    //creating a constructor of a class that initilize the value

    public ArrayList()
    {
        _count=0;
        _capacity=4;
        Array=new dynamic[_capacity];
    }
    public ArrayList(int size)
    {
        _count=0;
        _capacity=size;
        Array=new dynamic[_capacity];
    }
    //Creating a function that appends an element at the end of array
    public void AddElement(dynamic data)
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
        dynamic[] temp = new dynamic[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=Array[i];
        }
        Array=temp;
    }

    public void Insert(int index,dynamic value)
        {
          
        dynamic[] temp1 = new dynamic[_capacity];
        for(int i=0;i<_count+1;i++)
        {
            if(i<index)
            {
                temp1[i]=Array[i];
            }
            else if(i==index)
            {
                temp1[i]=value;
               
            }
            else
            {
                temp1[i]=Array[i-1];
            }
            System.Console.WriteLine(temp1[i]);
        }
        }
        public void RemoveAt(int index)
        {
        for(int i=index;i<_count-1;i++)
        {

            Array[i]=Array[i+1];            
        }
        for(int i=0;i<_count-1;i++)
        {
            if(i<index)
            {
                Array[i]=Array[i];
            }
            else if(i==index)
            {
                Array[i]=Array[i];
            }
            System.Console.WriteLine(Array[i]);
        }

        }
        public void Remove(dynamic values)
        {
            
        for(int i=0;i<_count-1;i++)
        {
            if(Array[i].Equals(values))
            {
                Array[i]=Array[i+1];
            }
            System.Console.WriteLine(Array[i]);
        }

        public void Insert(int index,dynamic value)
        {
          
        dynamic[] temp1 = new dynamic[_capacity];
        for(int i=0;i<_count+1;i++)
        {
            if(i<index)
            {
                temp1[i]=Array[i];
            }
            else if(i==index)
            {
                temp1[i]=value;
               
            }
            else
            {
                temp1[i]=Array[i-1];
            }
            System.Console.WriteLine(temp1[i]);
        }
        }
        public void RemoveAt(int index)
        {
        for(int i=index;i<_count-1;i++)
        {

            Array[i]=Array[i+1];            
        }
        for(int i=0;i<_count-1;i++)
        {
            if(i<index)
            {
                Array[i]=Array[i];
            }
            else if(i==index)
            {
                Array[i]=Array[i];
            }
            System.Console.WriteLine(Array[i]);
        }

        }
        public void Remove(dynamic values)
        {
            
        for(int i=0;i<_count-1;i++)
        {
            if(Array[i].Equals(values))
            {
                Array[i]=Array[i+1];
            }
            System.Console.WriteLine(Array[i]);
        }
        }
        }
    }
}