using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.ViewModels
{
    public class FileViewModel
    {
        [Required]
        [DisplayName("Mi archivo")]
        public HttpPostedFileBase File1 { get; set; }
        [Required]
        [DisplayName("Mi archivo 2")]
        public HttpPostedFileBase File2 { get; set; }
        [Required]
        [DisplayName("Mi cadena")]
        public string Cadena { get; set; }
    }
}