using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DataAccess
{
    /// <summary>
    /// Simple wrapper class for more concise code by the callers.
    /// Other "getters" supported by <see cref="SqlDataReader"/> can easily be added.
    /// </summary>
    internal class DataRowReader : IDataRowReader
    {
        private readonly SqlDataReader reader;

        public DataRowReader(SqlDataReader reader)
        {
            this.reader = reader;
        }

        public bool Read()
        {
            return reader.Read();
        }

        public int GetInt32(string name)
        {
            return GetValue(name, reader.GetInt32);
        }

        public byte GetByte(string name)
        {
            return GetValue(name, reader.GetByte);
        }

        public bool GetBoolean(string name)
        {
            return GetValue(name, reader.GetBoolean);
        }

        public string GetString(string name)
        {
            return GetValue(name, reader.GetString);
        }

        public string GetDateTimeString(string name)
        {
            return GetDateTimemValue(name, reader.GetDateTime);
        }

        public T GetValue<T>(string name)
        {
                return (T)reader.GetValue(reader.GetOrdinal(name));
        }

        public T GetValue<T>(string name, Func<int, T> getter)
        {
            try
            {

                return reader.IsDBNull(reader.GetOrdinal(name)) ? default(T) : getter(reader.GetOrdinal(name));
                //Debug.WriteLine(name);
                //Debug.WriteLine(name);
            }
            catch (IndexOutOfRangeException ex)
            {
                Debug.WriteLine(name);
                throw new ColumnNotFoundException(name, ex);
            }
        }

        public string GetDateTimemValue<T>(string name, Func<int, T> getter)
        {
            try
            {
                string date1 = reader[name].ToString();

                return date1;

                //Debug.WriteLine(name);
                //Debug.WriteLine(name);
            }
            catch (IndexOutOfRangeException ex)
            {
                Debug.WriteLine(name);
                throw new ColumnNotFoundException(name, ex);
            }
        }

        DateTime IDataRowReader.GetDateTime(string name)
        {
            return GetValue(name, reader.GetDateTime);
        }
    }
}