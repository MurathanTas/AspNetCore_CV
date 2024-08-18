using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenersicService<T>
    {
        //Bu servisler business katmanında crud işlemleri için önemli olan metotlar çağrılmadan önce imzasını taşıyacak.
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
       
    }
}
