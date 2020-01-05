using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
  public  class IlanManager : IilanService
    {
        IilanDAL _ilanDAL;
        IilanBasvuruDAL _ıilanBasvuruDAL;
        public IlanManager(IilanDAL ilanDAL, IilanBasvuruDAL ıilanBasvuruDAL)
        {
            _ilanDAL = ilanDAL;
            _ıilanBasvuruDAL = ıilanBasvuruDAL;
        }

        public List<Ilan> GetList()
        {
            return _ilanDAL.GetList();
        }
        public Ilan GetByid(int id)
        {
            return _ilanDAL.Get(u => u.ID == id);
        }
        public void Add(Ilan ilan)
        {
            _ilanDAL.Add(ilan);
        }

        public void Update(Ilan ilan)
        {
            _ilanDAL.Update(ilan);
        }

        public void Delete(int id)
        {
            var data = _ilanDAL.Get(u => u.ID == id);
            _ilanDAL.Delete(data);

        }
        public List<Ilan> GetNotYet(int userId)
        {
            var basvurulanIlanlar=_ıilanBasvuruDAL.GetList(x => x.basvuranKullaniciID == userId).Select(x=>x.ilanID);
            return _ilanDAL.GetList(x=>!basvurulanIlanlar.Contains(x.ID));
        }

    }
}
