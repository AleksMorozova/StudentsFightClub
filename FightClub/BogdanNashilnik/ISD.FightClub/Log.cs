using System;
using System.Collections.Generic;
using System.IO;

namespace ISD.FightClub
{
    [Serializable]
    class Log : ILoggable
    {
        private List<string> log = new List<string>();

        public void Add(string data)
        {
            this.log.Add(data);
        }
        public void Clear()
        {
            this.log.Clear();
        }
        public void Save()
        {
            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.Write("\n");
                    foreach (string logRecord in this.log)
                    {
                        sr.Write("\n" + logRecord);
                    }
                }
            }
        }
        public List<string> ToList()
        {
            return this.log;
        }
    }
}
