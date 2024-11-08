using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace stotoDlyaDemExam
{
    class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-24HL4ATJ;Initial Catalog = nameryyMyyGanenyyn;Integrated Security = True");

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed) { SqlConnection.Open(); }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open) { SqlConnection.Close(); }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }

    }

}
