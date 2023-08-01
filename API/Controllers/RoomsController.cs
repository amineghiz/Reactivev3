using Application.Rooms;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RoomsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Room>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Room>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Room>> Create(Room room)
        {
            return Ok(await Mediator.Send(new Create.Command() { Room = room }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Room room)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Room = room, Id = id }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}