using System.Data;

namespace Encore.DAL.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}
