using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IEtkinlikService
    {
        List<Etkinlik> GetList();
        void Add(Etkinlik etkinlik);
        Etkinlik GetByid(int id);
        void Update(Etkinlik etkinlik);
        void Delete(int id);
    }
}
