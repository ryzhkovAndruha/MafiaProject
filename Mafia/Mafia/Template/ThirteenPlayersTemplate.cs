using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mafia.Interfaces;

namespace Mafia.Template
{
    public class ThirteenPlayersTemplate : ITemplate
    {
        int ITemplate.SuspectedMafiasInGameCount { get { return 3; } }
        int ITemplate.SuspectedDoctorsInGameCount { get { return 1; } }
        int ITemplate.SuspectedDetectivesInGameCount { get { return 1; } }
        int ITemplate.SuspectedDonesInGameCount { get { return 1; } }
        int ITemplate.SuspectedLoversInGameCount { get { return 0; } }
        int ITemplate.SuspectedManiacsInGameCount { get { return 1; } }
        int ITemplate.SuspectedCitizensInGameCount { get { return 6; } }

    }
}
