using System.Data.SqlClient;

namespace DAL
{
    public interface IDataDelegate
    {
        string ProcedureName { get; }

        void PrepareCommand(SqlCommand command);
    }
}