using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Core.Domain
{
    public class Colis
    {
        [Key]
        public DateTime DateLivraison { get; set; }
        public double Montant { get; set; }
        public double Poids { get; set; }
        public double Volume { get; set; }

        [ForeignKey("Client")]
        public int ClientFK { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Livreur")]
        public string LivreurFK { get; set; }
        public Livreur Livreur { get; set; }
    }
}
