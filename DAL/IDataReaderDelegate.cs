using System.Data.SqlClient;

namespace DAL
{
    public interface IDataReaderDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command, IDataRowReader reader);
    }
}