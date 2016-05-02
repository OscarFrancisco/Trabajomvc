using System;

namespace LogicaNegocio
{
    public interface IUnitOfWork: IDisposable
    {
        int SaveChanges();
    }
}
