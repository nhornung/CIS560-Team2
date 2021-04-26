using System.Data.SqlClient;

namespace DAL
{
    public interface INonQueryDataDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command);
    }
}