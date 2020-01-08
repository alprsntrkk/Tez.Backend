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

        public EtkinlikKatilim Delete(int id)
        {
            var data = _etkinlikKatilimDAL.Get(u => u.ID == id);
            _etkinlikKatilimDAL.Delete(data);
            return data;
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
        public List<EtkinlikKatilim> GetListByOwnerId(int userId)
        {
            return _etkinlikKatilimDAL.GetList(x=>x.etkinlikolusturanKullaniciID==userId && x.onayDurumu == false);
        }
        
        public List<EtkinlikKatilim> GetUnapprovedByEventId(int etkinlikId)
        {
            return _etkinlikKatilimDAL.GetList(x => x.etkinlikID == etkinlikId && x.onayDurumu == false);
        }
    }
}
