using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5.Classes
{
    public class Event
    {
        private string eventName;
        private DateTime date;
        private string details;
        private bool mandatory;
        private List<Worker> workers;
        private List<Customer> customers;

        //Constructor
        public Event(string eventName, DateTime date, string details, bool mandatory)
        {
            this.eventName = eventName;
            this.date = date;
            this.details = details;
            this.mandatory = mandatory;
            this.workers = new List<Worker>();
            this.customers = new List<Customer>();
        }
    }
}
