using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class IlanBasvuru : IEntity
    {
        public int ID { get; set; }
        public int ilanID { get; set; }
        public int basvuranKullaniciID { get; set; }
        public bool onayDurumu { get; set; }
        public string Aciklama { get; set; }
        public int ilansahibiKullaniciID { get; set; }
        public string telefonNo { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }
    }
}
