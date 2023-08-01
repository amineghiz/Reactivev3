using Application.Drinks;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DrinksController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Drink>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Drink>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Drink>> Create(Drink drink)
        {
            return Ok(await Mediator.Send(new Create.Command() { Drink = drink }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Drink drink)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Drink = drink, Id = id }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}