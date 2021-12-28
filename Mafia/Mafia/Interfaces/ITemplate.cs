using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Interfaces
{
    interface ITemplate
    {
        int SuspectedMafiasInGameCount { get; }
        int SuspectedDoctorsInGameCount { get; }
        int SuspectedDetectivesInGameCount { get; }
        int SuspectedDonesInGameCount { get; }
        int SuspectedLoversInGameCount { get; }
        int SuspectedManiacsInGameCount { get; }
        int SuspectedCitizensInGameCount { get; }
    }
}
