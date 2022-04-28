using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GE.Domain
{
    public class Trophee
    {
        [DataType(DataType.Date)]
        public DateTime DateTrophee { get; set; }

        [DataType(DataType.Currency)]
        public double Recompense { get; set; }
        [Key]
        public int TropheeId { get; set; }
        public String TypeTrophee { get; set; }
        public virtual Equipe Equipe { get; set; }
        [ForeignKey("Equipe")]
        public int EquipeFK { get; set; }

    }
}
