﻿using Advertising.Bll.BusinessLogic.Interfaces;
using AdvertisingService.Models;
using Common.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        [Route("categoryid={categoryId}/page={page}")]
        [Route("categoryid={categoryId}/title={title}/page={page}")]
        public async Task<IActionResult> ChangePage(string title = null, int? categoryId = 0, int page = 1)
        {
            int pageSize = 10;

            IEnumerable<AdvertisingModel> ads = await db.Advertisings.GetAllAsync();

            if (categoryId != null && categoryId != 0)
            {
                ads = ads.Where(p => p.AdvertisingCategoryId == categoryId);
            }
            if (!String.IsNullOrEmpty(title))
            {
                ads = ads.Where(p => p.AdvertisingName.Contains(title));
            }

            var count = ads.Count();

            var items = ads.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            SearchListModel viewModel = new SearchListModel
            {
                PageModel = new PageModel(count, page, pageSize),
                FilterModel = new FilterModel(await db.AdvertisingCategories.GetAllAsync(), categoryId, title),
                Ads = items
            };

            return Ok(viewModel);
        }

        // GET: api/AdvertisingModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            AdvertisingModel advertising = await db.Advertisings.GetItemByIdAsync(id);

            if (advertising == null)
            {
                return NotFound();
            }

            var category = await db.AdvertisingCategories.GetItemByIdAsync(advertising.AdvertisingCategoryId);

            AdFullModel adFullModel = new AdFullModel
            {
                Id = advertising.Id,
                AdvertisingName = advertising.AdvertisingName,
                Text = advertising.Text,
                ImagePath = advertising.ImagePath,
                ItemPrice = advertising.ItemPrice,
                AdvertisingCategoryId = advertising.AdvertisingCategoryId,
                CategoryName = category.CategoryName,
                UserId = advertising.UserId
            };

            return Ok(adFullModel);
        }

        [HttpGet]
        [Route("UsersAdvertisings")]
        public async Task<IActionResult> GetUsersAdvertisings()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;

            IEnumerable<AdvertisingModel> ads = await db.Advertisings.GetAllAsync();

            if (userId == null || userId == "")
            {
                return BadRequest();
            }

            ads = ads.Where(p => p.UserId == userId);

            return Ok(ads);
        }

        // PUT: api/AdvertisingModels/5
        [HttpPut("{id}")]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> Post(AdvertisingModel advertisingModel)
        {
            AdvertisingModel advertising;

            if (advertisingModel == null)
            {
                advertising = await db.Advertisings.CreateAsync(new AdvertisingModel
                {
                    AdvertisingName = "",
                    Text = "",
                    ImagePath = "",
                    ItemPrice = "",
                    AdvertisingCategoryId = 0,
                    UserId = ""
            });

                return Ok(advertising);
            }
            else if (advertisingModel.ImagePath == null || advertisingModel.ImagePath == "")
            {
                advertisingModel.ImagePath = "/assets/images/no_photo.png";
            }

            if(advertisingModel.ItemPrice == null || advertisingModel.ItemPrice == "")
            {
                advertisingModel.ItemPrice = "Договорная";
            }
            else
            {
                advertisingModel.ItemPrice += " р.";
            }

            advertisingModel.UserId = User.Claims.First(c => c.Type == "UserID").Value;

            advertising = await db.Advertisings.CreateAsync(advertisingModel);

            return Ok(advertising);
        }

        // DELETE: api/AdvertisingModels/5
        [HttpDelete("{id}")]
        [Authorize]
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
