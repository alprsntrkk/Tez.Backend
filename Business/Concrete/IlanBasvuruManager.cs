using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class IlanBasvuruManager : IilanBasvuruService
    {
        IilanBasvuruDAL _ilanBasvuruDAL;
        public IlanBasvuruManager(IilanBasvuruDAL ilanBasvuruDAL)
        {
            _ilanBasvuruDAL = ilanBasvuruDAL;
        }

        public List<IlanBasvuru> GetList()
        {
            return _ilanBasvuruDAL.GetList();
        }
        public IlanBasvuru GetByid(int id)
        {
            return _ilanBasvuruDAL.Get(u => u.ID == id);
        }
        public void Add(IlanBasvuru ilan)
        {
            _ilanBasvuruDAL.Add(ilan);
        }

        public void Update(IlanBasvuru ilan)
        {
            _ilanBasvuruDAL.Update(ilan);
        }

        public IlanBasvuru Delete(int id)
        {
            var data = _ilanBasvuruDAL.Get(u => u.ID == id);
            _ilanBasvuruDAL.Delete(data);
            return data;

        }
        public List<IlanBasvuru> GetListByOwnerId(int userId)
        {
            return _ilanBasvuruDAL.GetList(x=>x.ilansahibiKullaniciID==userId && x.onayDurumu==false);
        }
        public List<IlanBasvuru> GetUnapprovedByIlanId(int ilanId)
        {
            return _ilanBasvuruDAL.GetList(x => x.ilanID == ilanId && x.onayDurumu == false);
        }
    }
}
