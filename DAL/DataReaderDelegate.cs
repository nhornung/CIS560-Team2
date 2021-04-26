using System.Data.SqlClient;

namespace DAL
{
    public abstract class DataReaderDelegate<T> : DataDelegate, IDataReaderDelegate<T>
    {
        protected DataReaderDelegate(string procedureName)
           : base(procedureName)
        {
        }

        public abstract T Translate(SqlCommand command, IDataRowReader reader);
    }
}