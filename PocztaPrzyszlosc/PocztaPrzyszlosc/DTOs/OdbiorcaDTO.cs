using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocztaPrzyszlosc
{
    public class OdbiorcaDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Nazwa { get; set; }
        public string Email { get; set; }
        public string Ulica { get; set; }
        public int NumerTeleofnu { get; set; }
        public int KodPocztowy { get; set; }
        public string Miasto { get; set; }

    }
}
