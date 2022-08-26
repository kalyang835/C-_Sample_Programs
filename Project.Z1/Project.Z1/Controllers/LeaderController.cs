using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Z1.Model;
using Project.Z1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Z1.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class LeaderController : ControllerBase
        {
            private readonly ILeaderRepository leaderRepository;
            public LeaderController(ILeaderRepository repository)
            {
                leaderRepository = repository;
            }

            [HttpGet]
            public IEnumerable<Leader> GetUsers()
            {
                try
                {
                    var result = leaderRepository.GetUsers();

                    return result;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            [HttpGet("{id:int}")]
            public ActionResult<Leader> GetUserById(int id)
            {
                try
                {
                    var result = leaderRepository.GetUser(id);

                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        ex.Message.ToString());
                }
            }

            [HttpPost]
            public ActionResult<bool> CreateUser(Leader users)
            {
                try
                {
                    if (users == null)
                        return BadRequest();

                    var isCreated = leaderRepository.AddUser(users);


                    return Ok(isCreated);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        ex.Message.ToString());
                }
            }

            [HttpPatch]
            public ActionResult<bool> UpdateUser(Leader users)
            {
                try
                {
                    if (users == null)
                        return BadRequest();

                    var isUpdated = leaderRepository.UpdateUser(users);

                    return Ok(isUpdated);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        ex.Message.ToString());
                }
            }

            [HttpDelete("{id:int}")]
            public ActionResult<bool> DeleteUser(int id)
            {
                try
                {
                    if (id <= 0)
                        return BadRequest();

                    var isUpdated = leaderRepository.DeleteUser(id);

                    return Ok(isUpdated);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        ex.Message.ToString());
                }
            }








        }
}
