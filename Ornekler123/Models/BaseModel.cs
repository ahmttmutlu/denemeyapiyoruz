using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler123.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Aciklama { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }=false;
        public DateTime OlusturulmaTarihi { get; set; }=DateTime.Now;
        public DateTime GuncellenmeTarihi { get; set; }= DateTime.Now;


        
    }
}
