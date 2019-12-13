using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class EtkinlikKatilimManager : IEtkinlikKatilimService
    {
        IEtkinlikKatilimDAL _etkinlikKatilimDAL;
        public EtkinlikKatilimManager(IEtkinlikKatilimDAL etkinlikKatilimDal)
        {
            _etkinlikKatilimDAL = etkinlikKatilimDal;
        }
        public void Add(EtkinlikKatilim basvuru)
        {
            _etkinlikKatilimDAL.Add(basvuru);
        }

        public void Delete(int id)
        {
            var data = _etkinlikKatilimDAL.Get(u => u.ID == id);
            _etkinlikKatilimDAL.Delete(data);
        }

        public EtkinlikKatilim GetByid(int id)
        {
            return _etkinlikKatilimDAL.Get(u => u.ID == id);
        }

        public List<EtkinlikKatilim> GetList()
        {
            return _etkinlikKatilimDAL.GetList();
        }

        public void Update(EtkinlikKatilim basvuru)
        {
            _etkinlikKatilimDAL.Update(basvuru);
        }
    }
}
