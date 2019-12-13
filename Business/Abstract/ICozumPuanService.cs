using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICozumPuanService
    {
        List<CozumPuan> GetList();
        void Add(CozumPuan puan);
        CozumPuan GetByid(int id);
        
    }
}
