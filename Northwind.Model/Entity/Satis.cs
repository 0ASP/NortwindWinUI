using Core.Model;

namespace Northwind.Model.Entity
{
    public class Satis : BaseEntity, IBaseDomain
    {
        public int SatisId { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string MusteriID { get; set; }

        //--------------------------------------------
        public Personel Personel { get; set; }
    }
}
