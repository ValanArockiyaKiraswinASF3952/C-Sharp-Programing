using System;
using System.Collections;
namespace OnlineMediaStore
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        private int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();  //reset i value if no element in list
            return false;
        }
        public void Reset()
        {
            i=-1;
        }
        public Object Current
        {
            get{return Array[i];}
        }
    }
}