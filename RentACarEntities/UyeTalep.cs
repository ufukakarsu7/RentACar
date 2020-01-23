using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities
{
    public class UyeTalep
    {
        public int Id { get; set; }
        public string TalepBaslik { get; set; }
        public string TalepAciklama { get; set; }
        public int UyeId { get; set; }

        public string AdSoyad { get; set; }
        public string UyeMail { get; set; }
        public bool CozulduMu { get; set; }
    }
}
