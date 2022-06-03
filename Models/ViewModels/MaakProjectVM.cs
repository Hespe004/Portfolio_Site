using Portfolio_Site.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Site.Models.ViewModels
{
    public class MaakMeldingVM
    {
        public string UserID { get; set; }

        public int MeldingID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "De titel moet minimaal 3 karakters bevatten")]
        public string Titel { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "De omschrijving moet minimaal 10 karakters bevatten")]
        public string Omschrijving { get; set; }

        public virtual Categorie Categorie { get; set; }

        [Required]
        public int CategorieID { get; set; }
        public DateTime Datum { get; set; }

        public int FotoId { get; set; }

        [DisplayName("Upload foto")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload foto")]
        public IFormFile ImageFile { get; set; }

        public Boolean Gesloten { get; set; }

        public Boolean WordtVerwijderd { get; set; }

        public DateTime VerwijderDatum { get; set; }
    }
}
