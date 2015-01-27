using System.Collections.Generic;

namespace Encore.DAL.Interfaces
{
    public interface IEntityManager
    {
        List<T> GetEntitiesList<T>();
        T GetEntityById<T>(int Id);
    }
}