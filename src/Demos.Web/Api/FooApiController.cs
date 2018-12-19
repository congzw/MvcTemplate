using System;
using System.Web.Http;

namespace Demos.Web.Api
{
    public class FooApiController : ApiController
    {
        [HttpGet]
        [Route("Api/Foo/GetDate")]
        public string GetDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
