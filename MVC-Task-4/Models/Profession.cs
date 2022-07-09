using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Task_4.Models
{
    public class Profession
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Card> Cards{ get; set; }

    }
}
