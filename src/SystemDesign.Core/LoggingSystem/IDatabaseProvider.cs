

using System.Data.Common;
using System.Data.SqlClient;

namespace SystemDesign.Core.LoggingSystem;


public interface IDatabaseProvider
{
    void OpenConnection();
    SqlCommand CreateCommand();
    void Execute(string query);
    void CloseConnection();
}