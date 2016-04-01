using System;

namespace GameProcess.BL.Fighters
{
    public class EventArgsFighter : EventArgs
    {
        public int HP { get; private set; }
        public string Name { get; private set; }

        public EventArgsFighter(int _hp, string _name)
        {
            HP = _hp;
            Name = _name;
        }
    }
    public class EventArgsBodyParts : EventArgs
    {
        public BodyParts Part { get; private set; }

        public EventArgsBodyParts(BodyParts _part)
        {
            Part = _part;
        }
    }
}

