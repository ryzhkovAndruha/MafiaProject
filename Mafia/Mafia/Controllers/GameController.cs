using Mafia.Entities;
using Mafia.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpPost]
        public ActionResult GiveRoleToPlayers()
        {
            RolesGenerator.CreatePlayersPreset(PlayersList.Players);
            return Ok();
        }

    }
}
