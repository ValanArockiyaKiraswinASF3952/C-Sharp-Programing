using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ParticalClass
{
     public partial class  StudentDetails 
    {
        
        private static int s_registerNumber=3000;

        public string RegisterNumber { get;  }        
        public string Name { get; set; }  //Auto Property
     
        public string FatherName { get; set; }

        public DateTime DOB { get; set; }
   
        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }
  
        public int Maths { get; set; }

        
        

        
        
    }
    
}