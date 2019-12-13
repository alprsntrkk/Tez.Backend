using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class HataManager : IHataService
    {
        IHataDAL _hataDAL;
        public HataManager(IHataDAL hataDAL)
        {
            _hataDAL = hataDAL;
        }

        public List<Hata> GetList()
        {
            return _hataDAL.GetList();
        }
        public Hata GetByid(int id)
        {
            return _hataDAL.Get(u => u.ID == id);
        }
        public void Add(Hata hata)
        {
            _hataDAL.Add(hata);
        }

        public void Update(Hata hata)
        {
            _hataDAL.Update(hata);
        }

        public void Delete(int id)
        {
            var data = _hataDAL.Get(u => u.ID == id);
            _hataDAL.Delete(data);

        }
    }
}
