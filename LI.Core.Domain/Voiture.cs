using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Core.Domain
{
    public class Voiture : Vehicule
    {
        public int NbrPlaces { get; set; }
    }
}










