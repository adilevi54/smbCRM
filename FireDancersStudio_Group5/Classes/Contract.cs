using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5
{
    public class Contract
    {
        private DateTime startDate;
        private int salary;
        private DateTime expirationDate;
        private bool permanent;
        private Worker workerID;

        public Contract(DateTime startDate, int salary, DateTime expirationDate, bool permanent, Worker workerID)
        {
            this.startDate = startDate;
            this.salary = salary;
            this.expirationDate = expirationDate;
            this.permanent = permanent;
            this.workerID = workerID;
        }
    }
}
