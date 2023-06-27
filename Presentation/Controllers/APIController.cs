using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class APIController : ControllerBase
    {
        public ISender _sender;

        public APIController(ISender sender)
        {
            _sender = sender;
        }
    }
}
