using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp
{
    class Delete
    {
        public static void RemoveDataCus(string table, string id)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                //DELETE FROM table_name WHERE condition;
                insertCommand.CommandText = "DELETE FROM " + table + " WHERE Customer_Id = @id";
                insertCommand.Parameters.AddWithValue("@id", id);

                insertCommand.ExecuteNonQuery();

                db.Close();
            }
        }
        public static void RemoveDataBook(string table, string id)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                //DELETE FROM table_name WHERE condition;
                insertCommand.CommandText = "DELETE FROM " + table + " WHERE ISBN = @id";
                insertCommand.Parameters.AddWithValue("@id", id);

                insertCommand.ExecuteNonQuery();

                db.Close();
            }
        }
    }
}