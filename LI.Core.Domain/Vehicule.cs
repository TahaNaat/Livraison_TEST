using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Core.Domain
{
    public class Vehicule
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Matricule { get; set; }
        public int VitesseLimite { get; set; }
        public ICollection<Livreur> Livreurs { get;
    }
}
