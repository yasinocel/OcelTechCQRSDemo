using Microsoft.AspNetCore.Mvc;

namespace OcelTech.Todo.WebApi.Controllers
{
    public class BaseController : Controller
    {
        protected BaseController() { }

        protected ObjectResult ValidationFailed()
        {
            return new ObjectResult(new
            {
                Message = "Validation Failed",
                Errors = ModelState.Keys.SelectMany(key => ModelState[key]!.Errors.Select(x => new { Field = key, Message = x.ErrorMessage })).ToList()

            })
            { StatusCode = StatusCodes.Status422UnprocessableEntity };
        }
    }
}
