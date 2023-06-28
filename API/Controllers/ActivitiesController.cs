using Application.Activities;
using Domain;
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

        [HttpGet("{Id}")]
        public async Task<ActionResult<Activity>> Get(Guid id)
        {
            return await Mediator.Send(new Details.Query() { Id = id });
        }
        [HttpPost]
        public async Task<ActionResult> Create(Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command() { Activity = activity }));
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Guid id, Activity activity)
        {
            activity.Id = id;
            return Ok(await Mediator.Send(new Edit.Command() { Activity = activity }));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command() { Id = id }));
        }
    }
}