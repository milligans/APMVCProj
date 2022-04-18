using AllplantsSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllplantsSelector.DAL
{
    public class DishRepository : IDishRepository
    {

        private AllplantsContext context;

        public DishRepository(AllplantsContext context)
        {
            this.context = context;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public Dish GetDishByID(int dishID)
        {
            return context.Dishes.Find(dishID);
        }

        public IEnumerable<Dish> GetDishes()
        {
            return context.Dishes.ToList();
        }
    }


}
