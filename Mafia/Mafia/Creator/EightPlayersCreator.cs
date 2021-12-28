using Mafia.Interfaces;
using Mafia.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Creator
{
    class EightPlayersCreator : ICreator
    {
        public ITemplate CreateTemplate()
        {
            return new EightPlayersTemplate();
        }
    }
}
