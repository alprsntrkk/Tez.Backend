using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEtkinlikKatilimService
    {
        List<EtkinlikKatilim> GetList();
        void Add(EtkinlikKatilim basvuru);
        EtkinlikKatilim GetByid(int id);
        void Update(EtkinlikKatilim basvuru);
        EtkinlikKatilim Delete(int id);
        List<EtkinlikKatilim> GetListByOwnerId(int userId);
        List<EtkinlikKatilim> GetUnapprovedByEventId(int userId);
    }
}
