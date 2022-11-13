using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Sample.Models
{
    public class Book
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int PbYear{ get; set; }
        public string Author { get; set; }
        public string Language  { get; set; }
    }
}