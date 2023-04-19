using BulkInsertWithAdoNet.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsertWithAdoNet.Data
{
    public class DataBaseCommon
    {
        public DataTable GetData(string connectionString,string TableName,string Columns)
        {
            DataTable dtPerson = new DataTable();
         
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand objSqlCommand = new SqlCommand("select "+ Columns + " from  " + TableName, con);

                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);

                 

                try
                {
                    objSqlDataAdapter.Fill(dtPerson);

                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }

            return dtPerson;



        }

        public void InsertData(string connectionString, string TableName, DataTable dtPerson )
        {

           

            string csDestination = connectionString;

            using (SqlConnection connection = new SqlConnection(csDestination))
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
            {
                foreach (DataColumn column in dtPerson.Columns)
                {
                   

                    bulkCopy.ColumnMappings.Add(
                      new()
                      {
                          SourceColumn = column.ColumnName,
                          DestinationColumn = column.ColumnName
                      }
                    );
                }

                connection.Open();
                bulkCopy.DestinationTableName = TableName;
                bulkCopy.WriteToServer(dtPerson);
            }
        }
    }
}
