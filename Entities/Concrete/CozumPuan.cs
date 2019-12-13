using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CozumPuan:IEntity
    {
        public int ID { get; set; }
        public int cozumID { get; set; }
        public int kullaniciID { get; set; }
        public int puan { get; set; }
    }
}
