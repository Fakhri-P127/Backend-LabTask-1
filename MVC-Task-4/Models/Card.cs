using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Task_4.Models
{
    public class Card
    {
        public int  Id { get; set; }
        public string Fullname { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FacebookIcon { get; set; }
        public string FacebookUrl { get; set; }
        public string PinterestIcon { get; set; }
        public string PinterestUrl { get; set; }
        public string VimeoIcon { get; set; }
        public string VimeoUrl { get; set; }
        public string TwitterIcon { get; set; }
        public string TwitterUrl { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
