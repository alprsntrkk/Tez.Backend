using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public  class IlanManager : IilanService
    {
        IilanDAL _ilanDAL;
        public IlanManager(IilanDAL ilanDAL)
        {
            _ilanDAL = ilanDAL;
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
    }
}
