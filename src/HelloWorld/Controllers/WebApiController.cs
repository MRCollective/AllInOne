using System.Web.Http;

namespace HelloWorld.Controllers
{
    public class WebApiController : ApiController
    {
        [Route("api/helloworld")]
        public MessageResponse Get()
        {
            return new MessageResponse
            {
                Message = "Hello World!"
            };
        }
    }

    public class MessageResponse
    {
        public string Message { get; set; }
    }

}