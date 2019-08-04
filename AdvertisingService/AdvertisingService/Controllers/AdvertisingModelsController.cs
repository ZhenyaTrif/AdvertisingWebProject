using Advertising.Bll.BusinessLogic.Interfaces;
using Common.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvertisingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisingModelsController : ControllerBase
    {
        private IBusinessLogic db;

        public AdvertisingModelsController(IBusinessLogic db)
        {
            this.db = db;
        }

        // GET: api/AdvertisingModels
        [HttpGet]
        public async Task<IEnumerable<AdvertisingModel>> Get()
        {
            return await db.Advertisings.GetAllAsync();
        }

        // GET: api/AdvertisingModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var advertising = await db.Advertisings.GetItemByIdAsync(id);

            if (advertising == null)
            {
                return NotFound();
            }

            return Ok(advertising);
        }

        // PUT: api/AdvertisingModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, AdvertisingModel advertisingModel)
        {
            if (advertisingModel == null)
            {
                return BadRequest();
            }

            if (id != advertisingModel.Id)
            {
                return BadRequest();
            }

            await db.Advertisings.UpdateAsync(advertisingModel);

            return Ok(advertisingModel);
        }

        // POST: api/AdvertisingModels
        [HttpPost]
        public async Task<IActionResult> Post(AdvertisingModel advertisingModel)
        {
            AdvertisingModel advertising;

            if (advertisingModel == null)
            {
                advertising = await db.Advertisings.CreateAsync(new AdvertisingModel
                {
                    Name = "",
                    Text = "",
                    ImagePath = "",
                    AdvertisingCategoryId = 0
                });

                return Ok(advertising);
            }

            advertising = await db.Advertisings.CreateAsync(advertisingModel);

            return Ok(advertising);
        }

        // DELETE: api/AdvertisingModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            await db.Advertisings.DeleteAsync(id);

            return Ok();
        }
    }
}
