using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio_Site.Models
{
    public class MeldingBase
    {
        [Key]
        public int MeldingID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "De titel moet minimaal 3 karakters bevatten")]
        public string Titel { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "De omschrijving moet minimaal 10 karakters bevatten")]
        public string Omschrijving { get; set; }

        public virtual Categorie Categorie { get; set; }

        public string Foto { get; set; }

        [Required]
        public int CategorieID { get; set; }
        public DateTime Datum { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload foto")]
        public IFormFile ImageFile { get; set; }

        public Boolean Gesloten { get; set; }

        public Boolean WordtVerwijderd { get; set; }

        public DateTime VerwijderDatum { get; set; }

    }
}
