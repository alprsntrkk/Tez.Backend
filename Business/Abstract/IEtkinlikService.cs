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
        Etkinlik Delete(int id);
        List<Etkinlik> GetNotYet(int userId);
        List<Etkinlik> GetByUserId(int userId);
    }
}
