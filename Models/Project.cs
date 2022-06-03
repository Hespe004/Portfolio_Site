using Portfolio_Site.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Site.Models
{
    public class Project : MeldingBase
    {

        public virtual _Portfolio_Site_User User { get; set; }
        public string UserID { get; set; }

        public int AantalViews { get; set; }

    }
}
