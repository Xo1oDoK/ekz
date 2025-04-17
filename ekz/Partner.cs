using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz
{
    public class Partner
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        //public int partner_type_id { get; set; }
        public Partner_type partner_type_id { get; set; }

        public int rating { get; set; }
        public string address { get; set; }
        public string director_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class Partner_type
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
