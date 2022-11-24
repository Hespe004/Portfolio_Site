using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Portfolio_Site.Models;

namespace Portfolio_Site.ViewModels
{
    public class Port_EigenaarViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Geboortedatum { get; set; }
        public string Adres { get; set; }

        public List<Hobby> Hobbys { get; set; }

        public string BeschrijvingProgrammeer { get; set; }
        public string MiddelbareSchool { get; set; }
        public string HogereSchool { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]  
        [Display(Name = "Profile Picture")]  
        public IFormFile ProfileImage { get; set; } 

    }
}
