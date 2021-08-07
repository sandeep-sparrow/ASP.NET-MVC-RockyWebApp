using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationType
    {
        // columns for Category table
        // using data annotations it tells entity framework that this columns needs
        // to be primary key
        [Key]
        public int Id { get; set; } // Identity auto increments
        public string Name { get; set; }

        // now we have out model, next we need to create a table in the our DB
        // so how do we do that using out Model?


    }
}
