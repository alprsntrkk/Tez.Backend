using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Etkinlik: IEntity
    {
        public int ID { get; set; }
        public string Yer { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int Kontenjan { get; set; }
        public int olusturanKullaniciID { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }

    }
    
    
}
