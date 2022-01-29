using Four.DAL;
using Four.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Four.Controllers
{
    public class FaqController: Controller
    {
        private readonly AppDbContext innerdb;
        public FaqController(AppDbContext _db)
        {
            innerdb = _db;
        }
        public IActionResult Index()
        {
            List<FAQ> faqs = innerdb.Faqs.ToList();
            return View(faqs);
        }
    }
}
