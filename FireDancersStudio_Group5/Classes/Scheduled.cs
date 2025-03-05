using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5.Classes
{
    internal class Scheduled
    {

        private string workerID;
        private DateTime start_time;
        private string roomID;

        public Scheduled(string workerID, DateTime start_time, string roomID)
        {
            this.workerID = workerID;
            this.start_time = start_time;
            this.roomID = roomID;
        }

        public string GetWorkerID()
        {
            return this.workerID;
        }

        public DateTime GetStartTime()
        {
            return this.start_time;
        }

        public string GetRoomID()
        {
            return this.roomID;
        }

    }
}
