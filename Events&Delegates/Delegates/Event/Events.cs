using System;
namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink = null; //user defiend event
        static int i;
        
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        // public static void EventStarter()
        // {
        //     i=0;
        //     System.Console.WriteLine("User Registration ");
        //     HandleEvent();  //call event triggering method
        // }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the followings events");
            eventlink(); //Event Trigger ->Like clicking a buttom
        }
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine("Event No: "+i+" is "+ _eventName+" Started");
        }

    }
}