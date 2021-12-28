using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mafia.Interfaces;
using Mafia.Template;

namespace Mafia.Creator
{
    class ElevenPlayersCreator : ICreator
    {
        public ITemplate CreateTemplate()
        {
            return new ElevenPlayersTemplate();
        }
    }
}
