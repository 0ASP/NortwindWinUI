using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model.Entity
{
    public class Kullanici:BaseEntity,IBaseDomain
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public DateTime? KayitTarihi { get; set; }
        //public Nullable<DateTime> KayitTarihi { get; set; }



        //string a = null;
        //int d = null; //hata!!
        //int? b = null;
        //Nullable<int> c = null;
    }
}
