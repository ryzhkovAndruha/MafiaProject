using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mafia.Interfaces;
using Mafia.Template;


namespace Mafia.Creator
{
    class TenPlayersCreator : ICreator
    {
        public ITemplate CreateTemplate()
        {
            return new TenPlayersTemplate();
        }
    }
}
