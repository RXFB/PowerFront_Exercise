namespace OperatorProductivity.Data.SQLServer;

using Dapper;
using Microsoft.Extensions.Configuration;
using OperatorProductivity.Domain.Reports;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class SQLServerChatRepository : IChatRepository
{
    private readonly string connectionString;

    public SQLServerChatRepository(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("DefaultConnection");
    }
    public IEnumerable<string> GetWebsites()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            var results = connection.Query<string>(
                sql: "select distinct Website from Conversation",
                commandType: CommandType.Text
            );

            return results;
        }
    }

    public IEnumerable<string> GetDevices()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            var results = connection.Query<string>(
                sql: "select distinct device from Visitor",
                commandType: CommandType.Text
            );

            return results;
        }
    }

    public IEnumerable<OperatorProductivityResult> GetOperatorProductivityResultReport(OperatorProductivityResultQueryFilter filter)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            var parameters = new DynamicParameters();
            parameters.Add("@StartDate", filter.StartDate, DbType.DateTime);
            parameters.Add("@EndDate", filter.EndDate, DbType.DateTime);
            parameters.Add("@Website", filter.Website, DbType.String);
            parameters.Add("@Device", filter.Device, DbType.String);

            var results = connection.Query<OperatorProductivityResult>(
                sql: "dbo.OperatorProductivity",
                param: parameters,
                commandType: CommandType.StoredProcedure
            );

            return results;
        }
    }
}
