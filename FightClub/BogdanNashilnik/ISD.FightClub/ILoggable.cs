using System.Collections.Generic;

namespace ISD.FightClub
{
    public interface ILoggable
    {
        void Add(string data);
        void Save();
        void Clear();
        List<string> ToList();
    }
}
