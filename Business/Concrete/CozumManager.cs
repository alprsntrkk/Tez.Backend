using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class CozumManager:ICozumService
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



    }
}
