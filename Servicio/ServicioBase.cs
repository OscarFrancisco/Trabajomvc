using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura;

namespace Servicio
{
    public class ServicioBase : IDisposable
    {
       readonly IUnitOfWork _unitOfWork;
       public ServicioBase(IUnitOfWork unitOfWork)
       {
           if (null == unitOfWork)
           {
               throw new ArgumentNullException("unitOfWork");
           }
           this._unitOfWork = unitOfWork;
       }
       public int SaveChanges()
       {
           return this._unitOfWork.SaveChanges();
       }
       public void Dispose()
       {
           this._unitOfWork.Dispose();
       }
    }
}
