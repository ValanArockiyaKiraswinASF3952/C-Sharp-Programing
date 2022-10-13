using System;
namespace CollegeAddmision
{
    public partial class List<Type>
    {
        private Type [] Array{get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}

        //Indexer
        public Type this[int i]
       {
           get{return Array[i];}
           set{Array[i]=value;}
        }

    //creating a constructor of a class that initilize the value

    public List()
    {
        _count=0;
        _capacity=4;
        Array=new Type[_capacity];
    }
    public List(int size)
    {
        _count=0;
        _capacity=size;
        Array=new Type[_capacity];
    }
    //Creating a function that appends an element at the end of array
    public void Add(Type data)
    {
        
        if(_count==_capacity)
        {
            
            GrowSize();
        }
        Array[_count]=data;
        _count++;
    }
    public void GrowSize()
    {
        _capacity=_capacity*2;
        Type[] temp = new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=Array[i];
        }
        Array=temp;
    }
    
     public void AddRange(List<Type> list)
    {
        Type [] Array1 = new Type[Count+list._count];
        for (int i=0;i<Count;i++)
        {
            Array1[i]=Array[i];
        }
        for (int i=0;i<list._count;i++)
        {
            Array1[Count+i]=list[i];
        }
        Array=Array1;
        _count+=list._count;
    }
    }
}