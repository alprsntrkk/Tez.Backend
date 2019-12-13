using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CozumPuanManager:ICozumPuanService
    {
        ICozumPuanDAL _cozumPuanDAL;
        public CozumPuanManager(ICozumPuanDAL cozumPuanDAL)
        {
            _cozumPuanDAL = cozumPuanDAL;
        }

        public List<CozumPuan> GetList()
        {
            return _cozumPuanDAL.GetList();
        }
        public CozumPuan GetByid(int id)
        {
            return _cozumPuanDAL.Get(u => u.ID == id);
        }
        public void Add(CozumPuan puan)
        {
            _cozumPuanDAL.Add(puan);
        }

       
    }
}
