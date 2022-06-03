using Portfolio_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Site.Models.ViewModels
{
    public class ProjectVerwijderenVM
    {
        public int Id { get; set; }
        public string Reden { get; set; }

        public DateTime VerwijderDatum { get; set; }

        public virtual Project Project { get; set; }
    }
}
