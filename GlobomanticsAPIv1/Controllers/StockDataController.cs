using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobomanticsAPIv1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockDataController : ControllerBase
    {

        List<StockData> currentStocks = new List<StockData>();
        public StockDataController()
        {
            currentStocks = new List<StockData>()
            {
                new StockData (){Ticker="Stk1",Price=110.5f},
                new StockData (){Ticker="Stk2",Price=66f},
                new StockData (){Ticker="Stk3",Price=14.7f},
                new StockData (){Ticker="Stk4",Price=56.8f},
            };
        }

        [HttpGet]
        public IEnumerable<StockData> Get()
        {
            return currentStocks.ToArray();
        }


    }
}
