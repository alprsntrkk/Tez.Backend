using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ilan : IEntity
    {
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public int kullaniciID { get; set; }
        public bool aktiflik { get; set; }
    }
}
