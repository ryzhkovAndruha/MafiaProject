using Mafia.Creator;
using Mafia.Entities;
using Mafia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mafia.Services
{
    public static class RolesGenerator
    {
        private static int _playersCount;
        private static List<Player> _players;
        private static Random _random;

        private static int _mafiasInGameCount;
        private static int _doctorsInGameCount;
        private static int _detectivesInGameCount;
        private static int _donesInGameCount;
        private static int _loversInGameCount;
        private static int _maniacsInGameCount;
        private static int _citizensInGameCount;

        private static ITemplate _template;

        public static void CreatePlayersPreset(List<Player> players)
        {
            AnalyzePlayers(players);
            GenereteGameRoles();
        }

        private static void GenereteGameRoles()
        {
            ICreator gameCreator = null;
            switch (_playersCount)
            {
                case 6:
                    gameCreator= new SixPlayersCreator();
                    break;
                case 7:
                    gameCreator = new SevenPlayersCreator();
                    break;
                case 8:
                    gameCreator = new EightPlayersCreator();
                    break;
                case 9:
                    gameCreator = new NinePlayersCreator();
                    break;
                case 10:
                    gameCreator = new TenPlayersCreator();
                    break;
                case 11:
                    gameCreator = new ElevenPlayersCreator();
                    break;
                case 12:
                    gameCreator = new TwelvePlayersCreator();
                    break;
                case 13:
                    gameCreator = new ThirteenPlayersCreator();
                    break;
                case 14:
                    gameCreator = new FourteenPlayersCreator();
                    break;
                case 15:
                    gameCreator = new FifteenPlayersCreator();
                    break;
            }
            _template = gameCreator.CreateTemplate();
            GiveRoles();
        }

       
        private static void GiveRoles()
        {
            for (int i = 0; i < _playersCount; i++)
            {
                var player = _players[i];
                SetRandomRole(player);
            }
        }

        private static void SetRandomRole(Player player)
        {
            Array roles = Enum.GetValues(typeof(Role));
            while (true)
            {
                Random random = new Random();
                Role randomRole = (Role)roles.GetValue(random.Next(roles.Length));

                if (randomRole == Role.Citizen && _citizensInGameCount < _template.SuspectedCitizensInGameCount)
                {
                    player.Role = randomRole;
                    _citizensInGameCount++;
                    break;
                }
                else if (randomRole == Role.Detecitve && _detectivesInGameCount < _template.SuspectedDetectivesInGameCount)
                {
                    player.Role = randomRole;
                    _detectivesInGameCount++;
                    break;
                }
                else if (randomRole == Role.Doctor && _doctorsInGameCount < _template.SuspectedDoctorsInGameCount)
                {
                    player.Role = randomRole;
                    _doctorsInGameCount++;
                    break;
                }
                else if (randomRole == Role.Lover && _loversInGameCount < _template.SuspectedLoversInGameCount)
                {
                    player.Role = randomRole;
                    _loversInGameCount++;
                    break;
                }
                else if (randomRole == Role.Mafia && _mafiasInGameCount < _template.SuspectedMafiasInGameCount)
                {
                    player.Role = randomRole;
                    _mafiasInGameCount++;
                    break;
                }
                else if (randomRole == Role.MafiaDon && _donesInGameCount < _template.SuspectedDonesInGameCount)
                {
                    player.Role = randomRole;
                    _donesInGameCount++;
                    break;
                }
                else if (randomRole == Role.Maniac && _maniacsInGameCount < _template.SuspectedManiacsInGameCount)
                {
                    player.Role = randomRole;
                    _maniacsInGameCount++;
                    break;
                }
            }
        }

        private static void AnalyzePlayers(List<Player> players)
        {
            _playersCount = players.Count;
            _players = players;
            _random = new Random();

            _mafiasInGameCount = 0;
            _doctorsInGameCount = 0; 
            _detectivesInGameCount = 0;
            _donesInGameCount = 0;
            _loversInGameCount = 0;
            _maniacsInGameCount = 0;
            _citizensInGameCount = 0;
        }
    }
}
