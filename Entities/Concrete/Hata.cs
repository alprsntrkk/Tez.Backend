using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Hata:IEntity
    {
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public int kullaniciID { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }
        public string hataBasligi { get; set; }
    }
}
