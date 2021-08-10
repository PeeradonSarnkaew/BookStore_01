using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp
{
    class Edit
    {
        public static void UpdatedataCus(string table, string id, string name, string address, string email)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                //UPDATE table_name
                //SET column1 = value1, column2 = value2, ...
                //WHERE condition;
                insertCommand.CommandText = "UPDATE " + table + " SET Customer_Name = @name, Address = @address, Email = @email WHERE Customer_Id = @id";
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@email", email);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }

        public static void UpdatedataBook(string table, string id, string title, string descrip, int price)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                //UPDATE table_name
                //SET column1 = value1, column2 = value2, ...
                //WHERE condition;
                insertCommand.CommandText = "UPDATE " + table + " SET Title = @title, Description = @descrip, Price = @price WHERE ISBN = @id";
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@title", title);
                insertCommand.Parameters.AddWithValue("@descrip", descrip);
                insertCommand.Parameters.AddWithValue("@price", price);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }
    }
}
