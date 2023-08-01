using Application.Halls;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    public class HallsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Hall>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Hall>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Hall>> Create(Hall Hall)
        {
            return Ok(await Mediator.Send(new Create.Command() { Hall = Hall }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Hall Hall)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Hall = Hall, Id = id }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}