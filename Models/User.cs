using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllplantsSelector.Models
    
{
    public enum Family
    {
        Ross,
        Eric,
        Sue,
    }
    public class User
    {
        
        public int UserId { get; set; }
        public Family Family { get; set; }
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
