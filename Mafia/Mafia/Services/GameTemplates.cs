using Mafia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mafia.Services
{
    public static class GameTemplates
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

        private static int _suspectedMafiasInGameCount;
        private static int _suspectedDoctorsInGameCount;
        private static int _suspectedDetectivesInGameCount;
        private static int _suspectedDonesInGameCount;
        private static int _suspectedLoversInGameCount;
        private static int _suspectedManiacsInGameCount;
        private static int _suspectedCitizensInGameCount;

        public static void CreatePlayersPreset(List<Player> players)
        {
            AnalyzePlayers(players);
            GenereteGameRoles();
        }

        private static void GenereteGameRoles()
        {
            switch (_playersCount)
            {
                case 6:
                    GenereteGameRolesForSixPlayers();
                    break;
                case 7:
                    GenereteGameRolesForSevenPlayers();
                    break;
                case 8:
                    GenereteGameRolesForEightPlayers();
                    break;
                case 9:
                    GenereteGameRolesForNinePlayers();
                    break;
                case 10:
                    GenereteGameRolesForTenPlayers();
                    break;
                case 11:
                    GenereteGameRolesForElevenPlayers();
                    break;
                case 12:
                    GenereteGameRolesForTwelvePlayers();
                    break;
                case 13:
                    GenereteGameRolesForThirteenPlayers();
                    break;
                case 14:
                    GenereteGameRolesForFourteenPlayers();
                    break;
                case 15:
                    GenereteGameRolesForFifteenPlayers();
                    break;
            }

            GiveRoles();
        }

        private static void GenereteGameRolesForFifteenPlayers()
        {
            _suspectedMafiasInGameCount = 4;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 1;
            _suspectedCitizensInGameCount = 8;
        }

        private static void GenereteGameRolesForFourteenPlayers()
        {
            _suspectedMafiasInGameCount = 3;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 1;
            _suspectedCitizensInGameCount = 8;
        }

        private static void GenereteGameRolesForThirteenPlayers()
        {
            _suspectedMafiasInGameCount = 3;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 1;
            _suspectedCitizensInGameCount = 6;
        }

        private static void GenereteGameRolesForTwelvePlayers()
        {
            _suspectedMafiasInGameCount = 3;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 1;
            _suspectedCitizensInGameCount = 5;
        }

        private static void GenereteGameRolesForElevenPlayers()
        {
            _suspectedMafiasInGameCount = 2;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 1;
            _suspectedCitizensInGameCount = 5;
        }

        private static void GenereteGameRolesForTenPlayers()
        {
            _suspectedMafiasInGameCount = 2;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 0;
            _suspectedCitizensInGameCount = 5;
        }

        private static void GenereteGameRolesForNinePlayers()
        {
            _suspectedMafiasInGameCount = 2;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 0;
            _suspectedCitizensInGameCount = 4;
        }

        private static void GenereteGameRolesForEightPlayers()
        {
            _suspectedMafiasInGameCount = 1;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 0;
            _suspectedCitizensInGameCount = 4;
        }

        private static void GenereteGameRolesForSevenPlayers()
        {
            _suspectedMafiasInGameCount = 1;
            _suspectedDoctorsInGameCount = 1;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 0;
            _suspectedCitizensInGameCount = 3;
        }

        private static void GenereteGameRolesForSixPlayers()
        {
            _suspectedMafiasInGameCount = 0;
            _suspectedDoctorsInGameCount = 0;
            _suspectedDetectivesInGameCount = 1;
            _suspectedDonesInGameCount = 1;
            _suspectedLoversInGameCount = 0;
            _suspectedManiacsInGameCount = 0;
            _suspectedCitizensInGameCount = 4;
        }

        private static void GiveRoles()
        {
            List<Player> players = new List<Player>(_players);

            for (int i = 0; i < _playersCount; i++)
            {
                var player = players[_random.Next(_playersCount - i)];
                SetRandomRole(player);
                var playerToSetRole = _players.Where(p => p.ID == player.ID).FirstOrDefault();
                playerToSetRole.Role = player.Role;
                players.Remove(player);
            }
        }

        private static void SetRandomRole(Player player)
        {
            Array roles = Enum.GetValues(typeof(Role));
            while (true)
            {
                Random random = new Random();
                Role randomRole = (Role)roles.GetValue(random.Next(roles.Length));

                if (randomRole == Role.Citizen && _citizensInGameCount < _suspectedCitizensInGameCount)
                {
                    player.Role = randomRole;
                    _citizensInGameCount++;
                    break;
                }
                else if (randomRole == Role.Detecitve && _detectivesInGameCount < _suspectedDetectivesInGameCount)
                {
                    player.Role = randomRole;
                    _detectivesInGameCount++;
                    break;
                }
                else if (randomRole == Role.Doctor && _doctorsInGameCount < _suspectedDoctorsInGameCount)
                {
                    player.Role = randomRole;
                    _doctorsInGameCount++;
                    break;
                }
                else if (randomRole == Role.Lover && _loversInGameCount < _suspectedLoversInGameCount)
                {
                    player.Role = randomRole;
                    _loversInGameCount++;
                    break;
                }
                else if (randomRole == Role.Mafia && _mafiasInGameCount < _suspectedMafiasInGameCount)
                {
                    player.Role = randomRole;
                    _mafiasInGameCount++;
                    break;
                }
                else if (randomRole == Role.MafiaDon && _donesInGameCount < _suspectedDonesInGameCount)
                {
                    player.Role = randomRole;
                    _donesInGameCount++;
                    break;
                }
                else if (randomRole == Role.Maniac && _maniacsInGameCount < _suspectedManiacsInGameCount)
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
