using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassicTours.Data;
using ClassicTours.Models;
namespace ClassicTours.Controllers
{
    public class UserController
    {
        private readonly DbContext _context;
        public UserController(DbContext dbContext)
        {
            _context=dbContext;
        }   
        //GET Users
        //public async Task<IActionResult> Index(
        //    string sortOrder,
        //    string currentFilter,
        //    string searchString,
        //    int? pageNumber1)
        //{ }


    }
}
