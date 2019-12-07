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
    }
}
