using System;

namespace DataAccess
{
    public interface IDataRowReader
    {
        bool Read();
        byte GetByte(string name);
        DateTime GetDateTime(string name);
        int GetInt32(string name);
        string GetString(string name);
        T GetValue<T>(string name);
        string GetDateTimeString(string name);
        double GetDouble(string name);
    }
}