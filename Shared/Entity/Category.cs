using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace PraticaSemanaIV.Shared.Entity
{
    public class Category
    {
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name{get;set;}
    }
}