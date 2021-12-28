using Mafia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Template
{
    public class EightPlayersTemplate : ITemplate
    {
        int ITemplate.SuspectedMafiasInGameCount { get { return 1; } }
        int ITemplate.SuspectedDoctorsInGameCount { get { return 1; } }
        int ITemplate.SuspectedDetectivesInGameCount { get { return 1; } }
        int ITemplate.SuspectedDonesInGameCount { get { return 1; } }
        int ITemplate.SuspectedLoversInGameCount { get { return 0; } }
        int ITemplate.SuspectedManiacsInGameCount { get { return 0; } }
        int ITemplate.SuspectedCitizensInGameCount { get { return 4; } }

    }
}
