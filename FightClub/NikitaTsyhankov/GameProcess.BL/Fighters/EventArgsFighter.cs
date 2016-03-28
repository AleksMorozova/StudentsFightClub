using System;

namespace GameProcess.BL.Fighters
{
    public class EventArgsFighter : EventArgs
    {
        public int HP { get; set; }
        public string Name { get; set; }
    }
    public class EventArgsBodyParts : EventArgs
    {
        public BodyParts _part;
    }
}

