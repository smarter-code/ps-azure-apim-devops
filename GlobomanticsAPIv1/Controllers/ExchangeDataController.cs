using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobomanticsAPIv1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeDataController : Controller
    {

        List<ExchangeData> currentExchanges = new List<ExchangeData>();

        public ExchangeDataController()
        {
            currentExchanges = new List<ExchangeData>()
            {
                new ExchangeData (){Name="IXIC"}, //Nasdaq Composite
                new ExchangeData (){Name="NYSE"},
            };
        }
        [HttpGet]
        public IEnumerable<ExchangeData> Get()
        {
            return currentExchanges.ToArray();
        }
    }
}
