using System;
namespace Ex1
{
    public class RegisterPerson
    {
        private static int s_registerId=1000;
        public string RegisterID { get; set; }
        public DateTime DateOfRegistration { get; set; }
        
        public RegisterPerson(DateTime dateOfRegistration)
        {
            
        }
    }
}