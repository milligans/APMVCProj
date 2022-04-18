using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllplantsSelector.Models
{
    public class Dish
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Rating { get; set; }
        [Display(Name="User")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        
        public string   Comment { get; set; }
        public DateTime Purchased { get; set; }
        public string   imgPath { get; set; }
    }
}
