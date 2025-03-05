using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5.Classes
{
    public class Room
    {
        private string roomID;
        private BranchEnum branch;
        private int capacity;
        private List<StudioClass> studioClasses;

        public Room(string roomID, BranchEnum branch, int capacity)
        {
            this.roomID = roomID;
            this.branch = branch;
            this.capacity = 0;
            this.studioClasses = new List<StudioClass>();
        }

        public string GetRoomID()
        {
            return roomID;
        }

        public BranchEnum GetBranch()
        {
            return branch;
        }

        public int GetCapacity()
        {
            return capacity;
        }

    }
}
