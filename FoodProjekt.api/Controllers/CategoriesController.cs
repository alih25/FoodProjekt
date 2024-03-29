﻿using FoodProjekt.api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodProjekt.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCatagories() =>
         Ok(await _context.Categories.AsNoTracking().ToListAsync());
    }
}
