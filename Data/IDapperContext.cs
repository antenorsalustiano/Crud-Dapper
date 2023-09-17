using System.Data;

namespace Crud_Dapper.Data
{
    public interface IDapperContext 
    {
        IDbConnection CreateConnection();
    }

}
