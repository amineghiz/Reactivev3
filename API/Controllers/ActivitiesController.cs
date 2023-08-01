using Application.Activities;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> Get()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{Id}/zineb")]
        public async Task<ActionResult<Activity>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost("zineb")]
        public async Task<ActionResult<Activity>> Create(Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command() { Activity = activity }));
        }
        [HttpPost("aabir")]
        public async Task<ActionResult<Activity>> Createabbir(Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command() { Activity = activity }));
        }

        [HttpPut("{Id}")] // Corrected placement of the HttpPut attribute
        public async Task<ActionResult> Edit(Guid id, Activity activity)
        {
            return Ok(await Mediator.Send(new Edit.Command() { Activity = activity, Id = id }));
        }

        [HttpDelete("{Id}")] // Corrected placement of the HttpDelete attribute
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}

