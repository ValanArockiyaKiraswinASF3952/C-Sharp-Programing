using System;
namespace CollegeAddmision
{
    public partial class List<Type>
    {
        public void Insert(int index,Type value)
        {
          
        Type[] temp1 = new Type[_capacity];
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
        public void Remove(Type values)
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