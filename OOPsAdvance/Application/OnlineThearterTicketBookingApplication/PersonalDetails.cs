using System;
namespace OnlineThearterTicketBookingApplication
{
    public class PersonalDetails
    {
        /// <summary>
        /// Class <see cref="PersonalDetails"/> property Name used to provide Name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Class <see cref="PersonalDetails"/> property Age used to provide Age of user
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Class <see cref="PersonalDetails"/> property Age used to provide phone Number of user
        /// </summary>
        public long PhoneNumber { get; set; }
        /// <summary>
        /// Constructor of <see cref="PersonalDetail"/> class sused to initilize value to its property
        /// </summary>
        /// <param name="name">Parameter name used to initialize value to a user Name to Name property</param>
        /// <param name="age">Parameter age used to initialize value to a user Age to Age property</param>
        /// <param name="phoneNumber">Parameter phoneNumber used to initialize value to a user phoneNumber to phoneNumber property</param>
        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
        
        public PersonalDetails()
        {
            
        }
    }
}