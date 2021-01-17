using System;
using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoDeDados
    {
        protected SQLiteConnection sqliteConnection;
        protected string ConnectionString = "Data Source=.\\BancoDeDados.db; Version=3;";
        public BancoDeDados()
        { }
        protected SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(this.ConnectionString);
            sqliteConnection.Open();
            return sqliteConnection;
        }
        protected void DbDisconnection()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
