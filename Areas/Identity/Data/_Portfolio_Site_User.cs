using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Portfolio_Site.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Portfolio_Site.Areas.Identity.Data
{
    public class _Portfolio_Site_User : IdentityUser
    {
        [PersonalData]
        public string Voornaam { get; set; }
        [PersonalData]
        public string Achternaam { get; set; }
        [PersonalData]
        public string Adres { get; set; }
        [PersonalData]
        public string Foto { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload foto")]
        public IFormFile ImageFile { get; set; }

        public virtual IList<Project> Projects { get; set; }

        internal Task<_Portfolio_Site_User> FindByIdAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
}
