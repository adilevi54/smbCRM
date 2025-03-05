using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5
{
    public class DanceStyle
    {
        private string description;
        private DanceStyleEnum danceStyle;
        private List<StudioClass> studioClasses;

        public DanceStyle(string description, DanceStyleEnum danceStyle, List<StudioClass> studioClasses)
        {
            this.description = description;
            this.danceStyle = danceStyle;
            this.studioClasses = studioClasses;
        }
    }
}
