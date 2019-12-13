using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IHataService
    {
        List<Hata> GetList();
        void Add(Hata hata);
        Hata GetByid(int id);
        void Update(Hata hata);
        void Delete(int id);

    }
}
