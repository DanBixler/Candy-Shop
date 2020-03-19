using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyrepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyrepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_candyrepository.GetAllCandy);

            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyrepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Bestsellers";
            return View(candyListViewModel);
        }
    }
}
