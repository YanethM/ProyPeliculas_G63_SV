using System.ComponentModel.DataAnnotations;
using System;
namespace PraticaSemanaIV.Shared.Entity
{
    public class Movie
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name{get;set;}
        public string Sinopsis{get;set;}
        public string Poster{get;set;}
        [Required (ErrorMessage ="El campo {0} es requerido")]
        public DateTime Premier{get;set;}
        public string Trailer{get;set;}
        public string ShortName
        {
            get{
               if (string.IsNullOrWhiteSpace(Name))
               {
                   return null;
               }
               if (Name.Length > 60){
                   return Name.Substring(0,60) + "...";
               }else{
                   return Name;
               }
            }
        }
    }
}