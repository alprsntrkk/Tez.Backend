using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IilanBasvuruService
    {
        List<IlanBasvuru> GetList();
        void Add(IlanBasvuru basvuru);
        IlanBasvuru GetByid(int id);
        void Update(IlanBasvuru basvuru);
        void Delete(int id);
        List<IlanBasvuru> GetListByOwnerId(int userId);
    }
}
