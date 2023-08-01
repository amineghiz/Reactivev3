using Application.Menus;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MenusController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Menu>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Menu>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Menu>> Create(Menu Menu)
        {
            return Ok(await Mediator.Send(new Create.Command() { Menu = Menu }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Menu Menu)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Menu = Menu, Id = id }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}