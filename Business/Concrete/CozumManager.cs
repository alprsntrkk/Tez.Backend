using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CozumManager:ICozumService
    {
        ICozumDAL _cozumDAL;
        public CozumManager(ICozumDAL cozumDAL)
        {
            _cozumDAL = cozumDAL;
        }

        public List<Cozum> GetList()
        {
            return _cozumDAL.GetList();
        }
        public Cozum GetByid(int id)
        {
            return _cozumDAL.Get(u => u.ID == id);
        }
        public void Add(Cozum cozum)
        {
            _cozumDAL.Add(cozum);
        }

        public void Update(Cozum cozum)
        {
            _cozumDAL.Update(cozum);
        }

        public void Delete(int id)
        {
            var data= _cozumDAL.Get(u => u.ID == id);
            _cozumDAL.Delete(data);
            
        }
        public List<Cozum> GetListByHataID(int id)
        {
            return _cozumDAL.GetList(u => u.hataID ==id);
        }
    }
}
