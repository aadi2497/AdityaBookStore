using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param = null); //Need to install Dapper Nuget Package 3.16.xx

        void Execute(string procedurename, DynamicParameters param = null);

        T OneRecord<T>(string procedurename, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
