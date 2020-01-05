using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IilanService
    {
        List<Ilan> GetList();
        void Add(Ilan ilan);
        Ilan GetByid(int id);
        void Update(Ilan ilan);
        void Delete(int id);
        List<Ilan> GetNotYet(int userId);
    }
}
