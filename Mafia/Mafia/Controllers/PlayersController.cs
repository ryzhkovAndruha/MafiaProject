using Mafia.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mafia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            return Ok(PlayersList.Players);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            var player = PlayersList.Players.Where(p => p.ID == id).FirstOrDefault();

            if (player == null)
            {
                return NoContent();
            }

            return Ok(player);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post(Player player)
        {
            PlayersList.Players.Add(player);
            return Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Player updatedPlayer)
        {
            var player = PlayersList.Players.Where(p => p.ID == id).FirstOrDefault();
            if(player == null)
            {
                return BadRequest();
            }

            player.IsAlive = updatedPlayer.IsAlive;
            player.NickName = updatedPlayer.NickName;
            player.Role = updatedPlayer.Role;

            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var player = PlayersList.Players.Where(p => p.ID == id).FirstOrDefault();

            if(player == null)
            {
                return BadRequest();
            }

            PlayersList.Players.Remove(player);
            return Ok();
        }
    }
}
