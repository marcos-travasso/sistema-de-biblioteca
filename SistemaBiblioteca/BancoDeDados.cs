using System.Data.SQLite;

namespace SistemaBiblioteca
{
    public class BancoDeDados
    {
        protected SQLiteConnection sqliteConnection;
        public BancoDeDados()
        { }
        protected SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=.\\BancoDeDados.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
