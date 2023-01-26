using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;

namespace WindowsFormsApp1
{
    public partial class DataForm : Form
    {
        private User user;

        public DataForm()
        {
            InitializeComponent();
        }

        private void HeaderOfTheTable()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idClient"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Спецификация";
            column2.Width = 100;
            column2.Name = "SURNAME";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Инофрмация";
            column3.Width = 400;
            column3.Name = "NAME";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Сроки";
            column4.Width = 120;
            column4.Name = "ADDRESS";
            column4.CellTemplate = new DataGridViewTextBoxCell();


            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);

            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//разрешаем менять данные
        }

        private void HeaderOfTheTable_Operator()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id Оператора"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idOperator"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Фамилия";
            column2.Width = 100;
            column2.Name = "SURNAME";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Имя";
            column3.Width = 400;
            column3.Name = "NAME";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Отчество";
            column4.Width = 120;
            column4.Name = "MIDDLE_NAME";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Телефон";
            column5.Width = 400;
            column5.Name = "PHONE_NUMBER";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            //var column6 = new DataGridViewColumn();
            //column6.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            //dataGrid.Columns.Add(column6);



            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//разрешаем менять данные
        }

        private void HeaderOfTheTable_Route()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id маршрута"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idRoute"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            //column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Длительность";
            column2.Width = 100;
            column2.Name = "DURATION_HOURS";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Длина";
            column3.Width = 400;
            column3.Name = "RANGE_KM";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Номер трассы";
            column4.Width = 120;
            column4.Name = "ROUTE_NUMBER";
            column4.CellTemplate = new DataGridViewTextBoxCell();


            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);


            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = true;//запрещаем пользователю изменять данные (!!!)
        }

        private void HeaderOfTheTable_Drive_vehicle()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id Управляющий транспортным средством"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idOperator"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Фамилия";
            column2.Width = 100;
            column2.Name = "SURNAME";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Имя";
            column3.Width = 400;
            column3.Name = "NAME";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Отчество";
            column4.Width = 120;
            column4.Name = "MIDDLE_NAME";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Телефон";
            column5.Width = 400;
            column5.Name = "PHONE_NUMBER";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Категория";
            column6.Width = 400;
            column6.Name = "CATEGORY";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Стаж";
            column7.Width = 400;
            column7.Name = "WORK_EXPERIENCE	";
            column7.CellTemplate = new DataGridViewTextBoxCell();


            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            dataGrid.Columns.Add(column6);
            dataGrid.Columns.Add(column7);


            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//разрешаем менять данные
        }

        private void HeaderOfTheTable_Order1()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id Заказа"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idOrder"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Дата Заказа";
            column2.Width = 100;
            column2.Name = "ORDER_DARE";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Дата Доставки";
            column3.Width = 400;
            column3.Name = "DILIVERY_DARE";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Id Клиента";
            column4.Width = 120;
            column4.Name = "idClient";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Id Оператора";
            column5.Width = 400;
            column5.Name = "idOperator";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Пункт Доставки";
            column6.Width = 400;
            column6.Name = "idPoint_delivery";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Id Товара";
            column7.Width = 400;
            column7.Name = "idProduct";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Id Отправителя";
            column8.Width = 400;
            column8.Name = "idSender";
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Id Транспортного средства";
            column9.Width = 400;
            column9.Name = "idTransport_vehicle";
            column9.CellTemplate = new DataGridViewTextBoxCell();


            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            dataGrid.Columns.Add(column6);
            dataGrid.Columns.Add(column7);
            dataGrid.Columns.Add(column8);
            dataGrid.Columns.Add(column9);



            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//разрешаем менять данные
        }


        private void HeaderOfTheTable_Transport_vehicle()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id транспортного средства"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idTransport_vehicle"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            //column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Id маршруат";
            column2.Width = 100;
            column2.Name = "idRoute";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Id водителя";
            column3.Width = 400;
            column3.Name = "idDrive_vehicle";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Грузоподъемность";
            column4.Width = 120;
            column4.Name = "LOAD_CAPACITY";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Категория транспорта";
            column5.Width = 120;
            column5.Name = "Vehicle_category";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            //var column6 = new DataGridViewColumn();
            //column6.HeaderText = "";
            //column6.Width = 60;
            //column6.Name = "";
            //column6.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            //dataGrid.Columns.Add(column6);

            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//запрещаем пользователю изменять данные (!!!)
        }

        private void HeaderOfTheTable_Sender()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id отправителя"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idSender"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Страна";
            column2.Width = 100;
            column2.Name = "COUNTRY";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Город";
            column3.Width = 400;
            column3.Name = "CITY";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Адрес";
            column4.Width = 120;
            column4.Name = "ADDRESS_S";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Индекс";
            column5.Width = 120;
            column5.Name = "INDEX";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);

            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//запрещаем пользователю изменять данные (!!!)
        }

        private void HeaderOfTheTable_Point_delivery()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id доставки"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idPoint_delivery"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Страна";
            column2.Width = 100;
            column2.Name = "COUNTRY";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Город";
            column3.Width = 400;
            column3.Name = "CITY";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Адрес";
            column4.Width = 120;
            column4.Name = "ADDRESS_S";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Индекс";
            column5.Width = 120;
            column5.Name = "INDEX";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);

            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//запрещаем пользователю изменять данные (!!!)
        }

        private void HeaderOfTheTable_Product()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id товара"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idProduct"; //текстовое имя колонки, его можно использовать вместо обращений по индексу

            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Вес";
            column2.Width = 100;
            column2.Name = "WEIGHT";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Габариты";
            column3.Width = 400;
            column3.Name = "OVERALL_DIMENSIONS";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Характеристика товара";
            column4.Width = 120;
            column4.Name = "PRODUCT_CHARACTERISTICS";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Цена";
            column5.Width = 120;
            column5.Name = "PRICE";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);

            dataGrid.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dataGrid.ReadOnly = false;//запрещаем пользователю изменять данные (!!!)
        }

        //добавление данных в табицу
        private void AddDataGrid(RowOfData row)
        {
            dataGrid.Rows.Add(row.idClient, row.SURNAME, row.NAME, row.ADDRESS);//добавляем строку в таблицу
        }

        private void AddDataGrid_Transport_vehicle(RowOfData_idTransport_vehicle row)
        {
            dataGrid.Rows.Add(row.idTransport_vehicle, row.idRoute, row.idDrive_vehicle, row.LOAD_CAPACITY, row.Vehicle_category);//добавляем строку в таблицу
        }

        private void AddDataGrid_Sender(RowOfData_idSender row)
        {
            dataGrid.Rows.Add(row.idSender, row.COUNTRY, row.CITY, row.ADDRESS_S, row.INDEX);//добавляем строку в таблицу
        }

        private void AddDataGrid_Point_delivery(RowOfData_idPoint_delivery row)
        {
            dataGrid.Rows.Add(row.idPoint_delivery, row.COUNTRY, row.CITY, row.ADDRESS, row.INDEX);//добавляем строку в таблицу
        }

        private void AddDataGrid_Product(RowOfData_idProduct row)
        {
            dataGrid.Rows.Add(row.idProduct, row.WEIGHT, row.OVERALL_DIMENSIONS, row.PRODUCT_CHARACTERISTICS, row.PRICE);//добавляем строку в таблицу
        }

        private void AddDataGrid_Route(RowOfData_idRoute row)
        {
            dataGrid.Rows.Add(row.idRoute, row.DURATION_HOURS, row.RANGE_KM, row.ROUTE_NUMBER);//добавляем строку в таблицу
        }

        private void AddDataGrid_Operator(RowOfData_idOperator row)
        {
            dataGrid.Rows.Add(row.idOperator, row.SURNAME, row.NAME, row.MIDDLE_NAME, row.PHONE_NUMBER);//добавляем строку в таблицу
        }

        private void AddDataGrid_Drive_vehicle(RowOfData_idDrive_vehicle row)
        {
            dataGrid.Rows.Add(row.idDrive_vehicle, row.SURNAME, row.NAME, row.MIDDLE_NAME, row.PHONE_NUMBER, row.CATEGORY, row.WORK_EXPERIENCE);//добавляем строку в таблицу
        }

        private void AddDataGrid_Order1(RowOfDataid_Order1 row)
        {
            dataGrid.Rows.Add(row.idOrder, row.ORDER_DARE, row.DILIVERY_DARE, row.idClient, row.idOperator, row.idPoint_delivery, row.idProduct, row.idSender, row.idTransport_vehicle);//добавляем строку в таблицу
        }

        private void DataForm_Shown_Client()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable();//создаем шапку таблицы
            List<RowOfData> _data = new List<RowOfData>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `client`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData row = new RowOfData(_reader["idClient"], _reader["SURNAME"], _reader["NAME"], _reader["ADDRESS"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
                    dataGrid.Rows[i].Cells[0].ReadOnly = true;//запрещаем менять id
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Drive_vehicle()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Drive_vehicle();//создаем шапку таблицы
            List<RowOfData_idDrive_vehicle> _data = new List<RowOfData_idDrive_vehicle>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `drive_vehicle`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idDrive_vehicle row = new RowOfData_idDrive_vehicle(_reader["idDrive_vehicle"], _reader["SURNAME"], _reader["NAME"], _reader["MIDDLE_NAME"], _reader["PHONE_NUMBER"], _reader["CATEGORY"], _reader["WORK_EXPERIENCE"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid_Drive_vehicle(_data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Operator()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Operator();//создаем шапку таблицы
            List<RowOfData_idOperator> _data = new List<RowOfData_idOperator>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `operator`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idOperator row = new RowOfData_idOperator(_reader["idOperator"], _reader["SURNAME"], _reader["NAME"], _reader["MIDDLE_NAME"], _reader["PHONE_NUMBER"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid_Operator(_data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Order1()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Order1();//создаем шапку таблицы
            List<RowOfDataid_Order1> _data = new List<RowOfDataid_Order1>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `order1`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfDataid_Order1 row = new RowOfDataid_Order1(_reader["idOrder"], _reader["ORDER_DARE"], _reader["DILIVERY_DARE"], _reader["idClient"], _reader["idOperator"], _reader["idPoint_delivery"], _reader["idProduct"], _reader["idSender"], _reader["idTransport_vehicle"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid_Order1(_data[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Point_delivery()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Point_delivery();//создаем шапку таблицы
            List<RowOfData_idPoint_delivery> _data = new List<RowOfData_idPoint_delivery>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `point_delivery`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idPoint_delivery row = new RowOfData_idPoint_delivery(_reader["idPoint_delivery"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS"], _reader["INDEX"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid_Point_delivery(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

       

        private void DataForm_Shown_Route()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Route();//создаем шапку таблицы
            List<RowOfData_idRoute> _data = new List<RowOfData_idRoute>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `route`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idRoute row = new RowOfData_idRoute(_reader["idRoute"], _reader["DURATION_HOURS"], _reader["RANGE_KM"], _reader["ROUTE_NUMBER"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid_Route(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }



        private void DataForm_Shown_Product()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Product();//создаем шапку таблицы
            List<RowOfData_idProduct> _data = new List<RowOfData_idProduct>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `product`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idProduct row = new RowOfData_idProduct(_reader["idProduct"], _reader["WEIGHT"], _reader["OVERALL_DIMENSIONS"], _reader["PRODUCT_CHARACTERISTICS"], _reader["PRICE"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid_Product(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Sender()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Sender();//создаем шапку таблицы
            List<RowOfData_idSender> _data = new List<RowOfData_idSender>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `sender`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idSender row = new RowOfData_idSender(_reader["idSender"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS"], _reader["INDEX"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid_Sender(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void DataForm_Shown_Transport_vehicle()
        {
            dataGrid.Columns.Clear();
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable_Transport_vehicle();//создаем шапку таблицы
            List<RowOfData_idTransport_vehicle> _data = new List<RowOfData_idTransport_vehicle>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `transport_vehicle`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData_idTransport_vehicle row = new RowOfData_idTransport_vehicle(_reader["idTransport_vehicle"], _reader["idRoute"], _reader["idDrive_vehicle"], _reader["LOAD_CAPACITY"], _reader["Vehicle_category"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid_Transport_vehicle(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }
        private void отправительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Sender();
        }

        private void DataForm_Shown(object sender, EventArgs e)
        {
            //создаем объект класса пользователь
            user = new User();

            HeaderOfTheTable();//создаем шапку таблицы
            List<RowOfData> _data = new List<RowOfData>();//создаем список данных

            //открываем базу данных и считываем с нее данные
            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `client`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    //заполняем данные
                    RowOfData row = new RowOfData(_reader["idClient"], _reader["SURNAME"], _reader["NAME"], _reader["ADDRESS"]);
                    _data.Add(row);
                }

                //добавляем в таблицу данные
                for (int i = 0; i < _data.Count; i++)
                    AddDataGrid(_data[i]);

            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходВОконоРегестрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            this.Hide();
            form.Show();
        }

        private void выходВОкноВходаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            this.Hide();
            form.Show();
        }

        private void редактироватьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Перейти в окно редактирования данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataUploadForm form = new DataUploadForm();
                    this.Hide();
                    form.Show();
                }
            }
            else
                MessageBox.Show("У вас нет доступа, чтобы совершить это действие!", "Ошибка!");
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Order1();
        }

        private void транспортноеСтредствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Transport_vehicle();
            //создаем объект класса пользователь
                   
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Product();
        }

        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGrid.Columns.Clear();
            DataForm_Shown_Route();           
        }

        private void заказToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Order1();
        }



        private void редактироватьДанныеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Перейти в окно редактирования данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataUploadForm form = new DataUploadForm();
                    this.Hide();
                    form.Show();
                }
            }
            else
                MessageBox.Show("У вас нет доступа, чтобы совершить это действие!", "Ошибка!");
        }

        private void клиентToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Client();
        }

        private void управляющийТранспортнымСредствомToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Drive_vehicle();
        }

        private void операторToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Operator();
        }

        private void пунктДоставкиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            DataForm_Shown_Point_delivery();
        }

        private void поискToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти в окно поиска данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SearchForm form = new SearchForm();
                this.Hide();
                form.Show();
            }
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа осуществляет поиск, редактирование, обновление и удаление данных . Панель быстрого доступа позволяет перемещаться между вкладками поиска и выгрызки , для обычного пользователя и вкладками редактирования и удаления для администратора. ");
        }
    }
    }


