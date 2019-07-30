using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advertising.Bll.BusinessLogic;
using Advertising.Bll.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvertisingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisingController : ControllerBase
    {
        private IBusinessLogic db;

        public AdvertisingController(IBusinessLogic db)
        {
            this.db = db;
        }


    }
}