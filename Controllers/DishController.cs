using AllplantsSelector.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllplantsSelector.Models;
namespace AllplantsSelector.Controllers
{
    public class DishController : Controller
    {
        private IDishRepository dishRepository;

        public DishController()
        {
            this.dishRepository = new DishRepository(new AllplantsContext());
        }

        //public DishController(IDishRepository dishRepository)
        //{
        //    this.dishRepository = dishRepository;
        //}
        //GET : Dishes

        public ViewResult Index()
        {
            var dishes = from g in dishRepository.GetDishes()
                         select g;
            return View(dishes);
        }
       
    }
}
