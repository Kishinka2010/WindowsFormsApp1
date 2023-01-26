using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class DatabaseManager
    {
        //создаем поле данных соеденения с MySql
        static string host = "127.0.0.1";
        static string database = "transport";
        static string userDB = "root";
        static string password = "root";
        static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        MySqlConnection connection = new MySqlConnection(strProvider);

        //метод, который открывает соеденение
        public void OpenConnection()
        {
            //проверяем состояние подключения
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        //закрываем соеденение
        public void CloseConnection() 
        {
            //проверяем, есть ли соеденение 
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //возращаем значения объекта соеденения
        public MySqlConnection GetConnection { get { return connection; } }

    }
}
