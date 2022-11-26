using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Portfolio_Site.Models
{
    public class Port_Eigenaar
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Geboortedatum { get; set; }

        public string Nationaliteit { get; set; }

        //contact info
        public string Adres { get; set; }
        public string PostCode { get; set; }
        public string Plaats { get; set; }
        public string LinkedIn { get; set; }

        public string BeschrijvingProgrammeer { get; set; }

        [Required(ErrorMessage = "Please choose profile picture")]  
        public string ProfilePicture { get; set; }  

        public int Telefoon { get; set; }
        public string Email { get; set; }

    }

    public class Hobby {
        [Key]
        public int Id { get; set; }

        public Port_Eigenaar port_Eigenaar { get; set; }

        public string Naam { get; set; }
    }

    public class Programeertaal
    {
        [Key]
        public int Id { get; set; }

        public Port_Eigenaar port_Eigenaar { get; set; }
        
        public string Naam { get; set; }
        public int Kennis { get; set; }
    }

    public class MiddelbareSchool
    {
        [Key]
        public int Id { get; set; }

        public Port_Eigenaar port_Eigenaar { get; set; }
        
        public string Naam { get; set; }
        public string Opleiding { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Begin_Datum { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Eind_Datum { get; set; }
    }

    public class HogereSchool
    {
        [Key]
        public int Id { get; set; }

        public Port_Eigenaar port_Eigenaar { get; set; }
        
        public string Naam { get; set; }
        public string Opleiding { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Begin_Datum { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Eind_Datum { get; set; }
    }
}
