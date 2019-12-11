using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitTestApp.Models
{
    public class Car
    {
        [Key]
        public string RegistrationNumber { get; set; }

    }
}
