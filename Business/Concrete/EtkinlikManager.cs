using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   public  class EtkinlikManager : IEtkinlikService
    {
        IEtkinlikDAL _etkinlikDAL;
        IEtkinlikKatilimDAL _etkinlikKatilimDAL;
        public EtkinlikManager(IEtkinlikDAL etkinlikDal, IEtkinlikKatilimDAL etkinlikKatilimDAL)
        {
            _etkinlikDAL = etkinlikDal;
            _etkinlikKatilimDAL = etkinlikKatilimDAL;
        }
        public void Add(Etkinlik etkinlik)
        {
            _etkinlikDAL.Add(etkinlik);
        }

        public void Delete(int id)
        {
            var data = _etkinlikDAL.Get(u => u.ID == id);
            _etkinlikDAL.Delete(data);
        }

        public Etkinlik GetByid(int id)
        {
            return _etkinlikDAL.Get(u => u.ID == id);
        }

        public List<Etkinlik> GetList()
        {
            return _etkinlikDAL.GetList();
        }

        public void Update(Etkinlik etkinlik)
        {
            _etkinlikDAL.Update(etkinlik);
        }
        public List<Etkinlik> GetNotYet(int userId)
        {
            var basvurulanEtkinlikler = _etkinlikKatilimDAL.GetList(x => x.katilanKullaniciID == userId).Select(x => x.etkinlikID);
            return _etkinlikDAL.GetList(x => !basvurulanEtkinlikler.Contains(x.ID));
        }
    }
}
