using Microsoft.AspNetCore.Mvc;

namespace AdapterPatternWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private IXMLToJsonAdapter _xMLToJsonAdapter;
        public DataController(IXMLToJsonAdapter xMLToJsonAdapter)
        {
            this._xMLToJsonAdapter = xMLToJsonAdapter;
        }
        [HttpGet(Name = "GetJsonData")]
        public string Get(string fileName)
        {
            return _xMLToJsonAdapter.Parse(fileName);
        }
    }
}