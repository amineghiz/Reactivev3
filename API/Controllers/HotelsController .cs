using Application.Hotels;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class HotelsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Hotel>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Hotel>> Create(Hotel hotel)
        {
            return Ok(await Mediator.Send(new Create.Command() { Hotel = hotel }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Hotel Hotel)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Hotel = Hotel, Id = id }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}