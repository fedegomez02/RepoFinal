using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebEscuelaMVC.Models
{
    public class AulaContext :DbContext
    {
        public AulaContext():base("KeyDBEscuela") { }

        public DbSet<Aula>Aulas{ get; set; }
    }
}