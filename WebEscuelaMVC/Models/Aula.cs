using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebEscuelaMVC.Validations;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {
        public int Id { get; set; }
        [Required]
        [CheckAula]
        public string Numero{ get; set; }
        [Required]
        public string tipo{ get; set; }

    }
}