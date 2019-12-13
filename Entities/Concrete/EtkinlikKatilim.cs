using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class EtkinlikKatilim:IEntity
    {
        public int ID { get; set; }
        public int  etkinlikID { get; set; }
        public int katilanKullaniciID { get; set; }
        public bool onayDurumu { get; set; }
        

    }
}
