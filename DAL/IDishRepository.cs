using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllplantsSelector.Models;

namespace AllplantsSelector.DAL
{
    public interface IDishRepository : IDisposable
    {
        IEnumerable<Dish> GetDishes();
        Dish GetDishByID(int dishID);
        
    }
}
