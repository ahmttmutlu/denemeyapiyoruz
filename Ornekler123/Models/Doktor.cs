using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler123.Models
{
    public class Doktor : BaseModel
    {
      
        public int TCKN { get; set; }

        public string MedulaSifresi {  get; set; }

        public int SertifikaKodu { get; set; }

        public int PinKodu { get; set; }
        
        public string SehirKodu { get; set; }
    }
}
