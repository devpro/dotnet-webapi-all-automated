using System.Collections.Generic;
using Devpro.Examples.WebApiAllAutomated.WebApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.Controllers
{
    [ApiController]
    [Route("podcast")]
    public class PodcastController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<PodcastDto> FindOneById(string id)
        {
            return Ok(new PodcastDto { Id = id });
        }


        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<PodcastDto>> FindAll()
        {
            return Ok(new List<PodcastDto> { new PodcastDto { Id = "1234" }, new PodcastDto { Id = "5678" } });
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public IActionResult Create(PodcastDto dto)
        {
            dto.Id = "1234";
            return CreatedAtAction(nameof(FindOneById), new { id = dto.Id }, dto);
        }
    }
}
