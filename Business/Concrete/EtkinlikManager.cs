using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class EtkinlikManager : IEtkinlikService
    {
        IEtkinlikDAL _etkinlikDAL;
        public EtkinlikManager(IEtkinlikDAL etkinlikDal)
        {
            _etkinlikDAL = etkinlikDal;
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
    }
}
