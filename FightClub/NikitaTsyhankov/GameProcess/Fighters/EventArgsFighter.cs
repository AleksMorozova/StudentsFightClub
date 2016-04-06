using System;

namespace GameProcess.Fighters
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

