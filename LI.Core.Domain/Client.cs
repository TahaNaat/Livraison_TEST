using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Core.Domain
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public ICollection<Colis> Colis { get; set; }
    }
 }
