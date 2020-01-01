using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;
namespace Business.Abstract
{
    public interface ICozumService
    {

        List<Cozum> GetList();
        void Add(Cozum cozum);
        Cozum GetByid(int id);
        void Update(Cozum cozum);
        void Delete(int id);
        List<Cozum> GetListByHataID(int id);

    }
}
