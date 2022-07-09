using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Task_4.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Percent { get; set; }
        public Card Card { get; set; }
        public int CardId { get; set; }


    }
}
