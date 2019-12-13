using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CozumDto : IDto
    {
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public int hataID { get; set; }
        public int kullaniciID { get; set; }
        public Double Puani { get; set; }
    }
}
