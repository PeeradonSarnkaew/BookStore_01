using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp
{
    class DataAccess
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
                 new SqliteConnection($"Filename=SQLBOOK.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Books (ISBN INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Title VARCHAR(100) NULL, " +
                    "Description VARCHAR(200) NULL," +
                    "Price INTEGER NULL)";
                String tableCommand2 = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (Customer_Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Customer_Name VARCHAR(100) NULL, " +
                    "Address VARCHAR(200) NULL," +
                    "Email INTEGER NULL)";
                String tableCommand3 = "CREATE TABLE IF NOT " +
                    "EXISTS Transactions (ISBN INTEGER NULL, " +
                    "Customer_Id INTEGER NULL, " +
                    "Quatity INTEGER NULL," +
                    "Total_Price INTEGER NULL)";

                SqliteCommand createTablebook = new SqliteCommand(tableCommand, db);
                SqliteCommand createTablecus = new SqliteCommand(tableCommand2, db);
                SqliteCommand createTableTransaction = new SqliteCommand(tableCommand3, db);

                createTablebook.ExecuteReader();
                createTablecus.ExecuteReader();
                createTableTransaction.ExecuteReader();
            }
        }
    }
}
