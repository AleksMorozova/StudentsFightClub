using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Combats
{
     interface ILoggable
    {
        void AddToLog(string append);
         void SaveLog();
    }
}
