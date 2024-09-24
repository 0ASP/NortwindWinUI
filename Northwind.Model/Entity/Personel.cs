using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model.Entity
{
    public class Personel : BaseEntity, IBaseDomain
    {
        public int PersonelId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Unvan { get; set; }
        public string Sehir { get; set; }
        public DateTime? IseBaslamaTarihi { get; set; }
        public string Notlar { get; set; }
        public string FotografPath { get; set; }

        //---------------------------------
        //Navigation Property
        public List<Satis> PersonelinSatislari { get; set; }
    }
}
