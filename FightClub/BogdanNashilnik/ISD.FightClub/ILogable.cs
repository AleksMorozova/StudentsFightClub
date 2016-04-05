namespace ISD.FightClub
{
    public delegate void Log(string data);
    interface ILogable
    {
        void AddToLog(string data);
        void SaveLog();
        event Log Logging;
    }
}
