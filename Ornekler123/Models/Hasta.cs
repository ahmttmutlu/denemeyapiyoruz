using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler123.Models
{
    public class Hasta:BaseModel
    {
        [MaxLength (11)] 
        public int TCKN { get; set; }
        public char Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; } 

        public string? GSM {  get; set; }


    }
}
