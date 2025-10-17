using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

public class ReportService
{
    private readonly DatabaseHelper _db;

    public ReportService()
    {
        _db = new DatabaseHelper();
    }

    public DataTable GetSalesReport(DateTime startDate, DateTime endDate, int[] storeIds, int[] productIds)
    {
        var parameters = new[]
        {
            new SqlParameter("@StartDate", startDate),
            new SqlParameter("@EndDate", endDate),
            new SqlParameter("@StoreIds", string.Join(",", storeIds)),
            new SqlParameter("@ProductIds", string.Join(",", productIds))
        };

        return _db.ExecuteStoredProcedure("GetSalesReport", parameters);
    }
}