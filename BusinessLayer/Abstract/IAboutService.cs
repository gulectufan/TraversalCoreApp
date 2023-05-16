using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // IGenericService'den miras al
    // T değeri olarak About gönder.
    public interface IAboutService:IGenericService<About>
    {
    }
}
