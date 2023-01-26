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
    public partial class DataUploadForm : Form
    {
        private List<RowOfData> _data = new List<RowOfData>();
        private List<RowOfData_idDrive_vehicle> _data_dv = new List<RowOfData_idDrive_vehicle>();
        private List<RowOfData_idOperator> _data_op = new List<RowOfData_idOperator>();
        private List<RowOfDataid_Order1> _data_or = new List<RowOfDataid_Order1>();//создаем список данных
        private List<RowOfData_idPoint_delivery> _data_pd = new List<RowOfData_idPoint_delivery>();//создаем список данных
        private List<RowOfData_idProduct> _data_pr = new List<RowOfData_idProduct>();//создаем список данных
        private List<RowOfData_idRoute> _data_ro = new List<RowOfData_idRoute>();//создаем список данных
        private List<RowOfData_idSender> _data_se = new List<RowOfData_idSender>();//создаем список данных
        private List<RowOfData_idTransport_vehicle> _data_tv = new List<RowOfData_idTransport_vehicle>();//создаем список данных

        private User user;
        public DataUploadForm()
        {
            InitializeComponent();
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
                    RowOfData_idRoute row = new RowOfData_idRoute(_reader["idRoute"], _reader["DURATION_HOURS"], _reader["RANGE"], _reader["ROUTE_NUMBER"]);
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
                    RowOfData_idSender row = new RowOfData_idSender(_reader["idSender"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS_S"], _reader["INDEX"]);
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
            HeaderOfTheTable_Transport_vehicle();//создаем шапку 
            dataGrid.Columns[0].ReadOnly = true;//запрещаем менять id
            user = new User();//содаем объект класса польователь, так как в нем есть статичная переменная, она будет одинакова для всех 
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

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно сохранили все изменения с базой данных?" +
                "\nИначе все изменения не сохранятся!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void выходВОкноВходаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно сохранили все изменения с базой данных?" +
               "\nИначе все изменения не сохранятся!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Authorization form = new Authorization();
                this.Hide();
                form.Show();
            }
        }

        private void выходВОконоРегестрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно сохранили все изменения с базой данных?" +
              "\nИначе все изменения не сохранятся!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Registration form = new Registration();
                this.Hide();
                form.Show();
            }
        }

       

        private void выгрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //формирование шапки таблицы
        private void HeaderOfTheTable()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id Клиента"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idClient"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            column1.ReadOnly = false;
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
            column4.HeaderText = "Адрес";
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

        private void DataUploadForm_Shown(object sender, EventArgs e)
        {
            user = new User();//содаем объект класса польователь, так как в нем есть статичная переменная, она будет одинакова для всех 
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void выбранныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void всеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void перейтиКПросмотруДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти в окно загрузки данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataForm form = new DataForm();
                this.Hide();
                form.Show();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //удаляем все текущие строки
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            dataGrid.RowCount = Convert.ToInt32(numericUpDown_forAddData.Value);//считываем количество строк
            dataGrid.ReadOnly = false;//разрешаем менять данные 

            for (int i = 0; i < dataGrid.Rows.Count; i++)
                dataGrid.Rows[i].Cells[0].ReadOnly = false;//запрещаем менять id 
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            MySqlDataReader _reader;
            
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();
                                     
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("SELECT * FROM `client`", _manager.GetConnection);
                    

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
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data.Count)
                        {
                            AddDataGrid(_data[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                    break;
                case 1:

                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_dv = new DatabaseManager();
                    MySqlCommand _command_dv = new MySqlCommand("SELECT * FROM `drive_vehicle`", _manager_dv.GetConnection);

                    try
                    {
                        _manager_dv.OpenConnection();
                        _reader = _command_dv.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idDrive_vehicle row = new RowOfData_idDrive_vehicle(_reader["idDrive_vehicle"], _reader["SURNAME"], _reader["NAME"], _reader["MIDDLE_NAME"], _reader["PHONE_NUMBER"], _reader["CATEGORY"], _reader["WORK_EXPERIENCE"]);
                            _data_dv.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_dv.Count)
                        {
                            AddDataGrid_Drive_vehicle(_data_dv[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_dv.CloseConnection();
                    }

                    break;

                case 2:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_op = new DatabaseManager();
                    MySqlCommand _command_op = new MySqlCommand("SELECT * FROM `operator`", _manager_op.GetConnection);

                    try
                    {
                        _manager_op.OpenConnection();
                        _reader = _command_op.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idOperator row = new RowOfData_idOperator(_reader["idOperator"], _reader["SURNAME"], _reader["NAME"], _reader["MIDDLE_NAME"], _reader["PHONE_NUMBER"]);
                            _data_op.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_op.Count)
                        {
                            AddDataGrid_Operator(_data_op[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_op.CloseConnection();
                    }
                    break;
                case 3:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_or = new DatabaseManager();
                    MySqlCommand _command_or = new MySqlCommand("SELECT * FROM `order1`", _manager_or.GetConnection);

                    try
                    {
                        _manager_or.OpenConnection();
                        _reader = _command_or.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfDataid_Order1 row = new RowOfDataid_Order1(_reader["idOrder"], _reader["ORDER_DARE"], _reader["DILIVERY_DARE"], _reader["idClient"], _reader["idOperator"], _reader["idPoint_delivery"], _reader["idProduct "], _reader["idSender"], _reader["idTransport_vehicle"]);
                            _data_or.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_or.Count)
                        {
                            AddDataGrid_Order1(_data_or[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_or.CloseConnection();
                    }
                    break;
                case 4:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_pd = new DatabaseManager();
                    MySqlCommand _command_pd = new MySqlCommand("SELECT * FROM `point_delivery`", _manager_pd.GetConnection);

                    try
                    {
                        _manager_pd.OpenConnection();
                        _reader = _command_pd.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idPoint_delivery row = new RowOfData_idPoint_delivery(_reader["idPoint_delivery"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS"], _reader["INDEX"]);
                            _data_pd.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_pd.Count)
                        {
                            AddDataGrid_Point_delivery(_data_pd[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_pd.CloseConnection();
                    }
                    break;
                case 5:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_pr = new DatabaseManager();
                    MySqlCommand _command_pr = new MySqlCommand("SELECT * FROM `product`", _manager_pr.GetConnection);
                    
                    try
                    {
                        _manager_pr.OpenConnection();
                        _reader = _command_pr.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idProduct  row = new RowOfData_idProduct(_reader["idProduct"], _reader["WEIGHT"], _reader["OVERALL_DIMENSIONS"], _reader["PRODUCT_CHARACTERISTICS"], _reader["PRICE"]);
                            _data_pr.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_pr.Count)
                        {
                            AddDataGrid_Product(_data_pr[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_pr.CloseConnection();
                    }
                    break;
                case 6:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_rout = new DatabaseManager();
                    MySqlCommand _command_rout = new MySqlCommand("SELECT * FROM `route`", _manager_rout.GetConnection);

                    try
                    {
                        _manager_rout.OpenConnection();
                        _reader = _command_rout.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idRoute  row = new RowOfData_idRoute(_reader["idRoute"], _reader["DURATION_HOURS"], _reader["RANGE_KM"], _reader["ROUTE_NUMBER"]);
                            _data_ro.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_ro.Count)
                        {
                            AddDataGrid_Route(_data_ro[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_rout.CloseConnection();
                    }
                    break;
                case 7:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_sen = new DatabaseManager();
                    MySqlCommand _command_sen = new MySqlCommand("SELECT * FROM `sender`", _manager_sen.GetConnection);                    

                    try
                    {
                        _manager_sen.OpenConnection();
                        _reader = _command_sen.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idSender row = new RowOfData_idSender(_reader["idSender"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS"], _reader["INDEX"]);
                            _data_se.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_se.Count)
                        {
                            AddDataGrid_Sender(_data_se[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_sen.CloseConnection();
                    }
                    break;
                case 8:
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();


                    dataGrid.ReadOnly = false;
                    //открываем базу данных
                    DatabaseManager _manager_tr = new DatabaseManager();
                    MySqlCommand _command_tr = new MySqlCommand("SELECT * FROM `transport_vehicle`", _manager_tr.GetConnection);                   

                    try
                    {
                        _manager_tr.OpenConnection();
                        _reader = _command_tr.ExecuteReader();

                        while (_reader.Read())
                        {
                            //заполняем данные
                            RowOfData_idTransport_vehicle row = new RowOfData_idTransport_vehicle(_reader["idTransport_vehicle"], _reader["idRoute"], _reader["idDrive_vehicle"], _reader["LOAD_CAPACITY"], _reader["Vehicle_category"]);
                                _data_tv.Add(row);
                        }

                        //добавляем в таблицу данные
                        int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                        if (i >= 0 && i < _data_tv.Count)
                        {
                            AddDataGrid_Transport_vehicle(_data_tv[i]);
                        }
                        else
                            MessageBox.Show("Выбран не правильный элемент!", "Ошибка!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_tr.CloseConnection();
                    }
                    break;
            }
            //удаляем все текущие строки
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();

            DataForm_Shown_Product();
        }

        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void транспортноеСтредствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i <= dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[0].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "")
                       // Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" )
                       // Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != "")
                        {
                            string _commandString = "INSERT INTO `transport_vehicle` (`idTransport_vehicle`, `idRoute`, `idDrive_vehicle`, `LOAD_CAPACITY`,`Vehicle_category`) " +
                            "VALUES(@idTransport_vehicle, @idRoute, @idDrive_vehicle, @LOAD_CAPACITY, @Vehicle_category)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idTransport_vehicle", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@idRoute", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@idDrive_vehicle", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@LOAD_CAPACITY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@Vehicle_category", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void маршрутToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" 
                        //Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                     //   Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != ""
                     )
                        {
                            string _commandString = "INSERT INTO `route`(`idRoute`, `DURATION_HOURS`, `RANGE_KM`, `ROUTE_NUMBER`) " +
                            "VALUES(@idRoute, @DURATION_HOURS, @RANGE_KM, @ROUTE_NUMBER)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idRoute", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@DURATION_HOURS", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@RANGE_KM", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@ROUTE_NUMBER", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void отправительToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 
                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != ""
                     //Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                     //   Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != ""
                     )
                        {
                            string _commandString = "INSERT INTO `sender`(`idSender`, `COUNTRY`, `CITY`, `ADDRESS`, `INDEX`) " +
                            "VALUES(@idSender, @COUNTRY, @CITY, @ADDRESS, @INDEX)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idSender", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@COUNTRY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@ADDRESS", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@INDEX", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void клиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "")
                        {
                            string _commandString = "INSERT INTO `client` (`SURNAME`, `NAME`, `ADDRESS`) " +
                            "VALUES(@SURNAME, @NAME, @ADDRESS)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@SURNAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@ADDRESS", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value);

                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void операторToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void операторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "")
                        {
                            string _commandString = "INSERT INTO `operator` (`idOperator`, `SURNAME`, `NAME`, `MIDDLE_NAME`, `PHONE_NUMBER`) " +
                            "VALUES(@idOperator, @SURNAME, @NAME, @MIDDLE_NAME, @PHONE_NUMBER)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idOperator", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@SURNAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@PHONE_NUMBER", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value);

                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void товарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "")
                        {
                            string _commandString = "INSERT INTO `product` (`idProduct`, `WEIGHT`, `OVERALL_DIMENSIONS`, `PRODUCT_CHARACTERISTICS`, `PRICE`) " +
                            "VALUES(@idProduct, @WEIGHT, @OVERALL_DIMENSIONS, @PRODUCT_CHARACTERISTICS, @PRICE)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idProduct", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@WEIGHT", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@OVERALL_DIMENSIONS", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@PRODUCT_CHARACTERISTICS", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@PRICE", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;

                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void товарToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "" &&
                             Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value) != "")
                        {
                            
                            string idProduct = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                            string WEIGHT = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string OVERALL_DIMENSIONS = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string PRODUCT_CHARACTERISTICS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string PRICE = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `product` SET idProduct = " + idProduct + ", " +
                                    "WEIGHT = " + WEIGHT + ", " +
                                    "OVERALL_DIMENSIONS = " + OVERALL_DIMENSIONS + ", " +
                                    "PRODUCT_CHARACTERISTICS = " + PRODUCT_CHARACTERISTICS + ", " +
                                    "PRICE = " + PRICE + " " +
                                    "WHERE idProduct = " + idProduct;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[5].Value) != "")


                            {
                                string idProduct = Convert.ToString(this.dataGrid.Rows[i].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                                string WEIGHT = Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value);
                                string OVERALL_DIMENSIONS = Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value);
                                string PRODUCT_CHARACTERISTICS = Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value);
                                string PRICE = Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value);



                                string _comanndString = "UPDATE `product` SET idProduct = " + idProduct + ", " +
                                    "WEIGHT = " + WEIGHT + ", " +
                                    "OVERALL_DIMENSIONS = " + OVERALL_DIMENSIONS + ", " +
                                    "PRODUCT_CHARACTERISTICS = " + PRODUCT_CHARACTERISTICS + ", " +
                                    "PRICE = " + PRICE + " " +
                                    "WHERE idProduct = " + idProduct;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void маршрутToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idRoute = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                            string DURATION_HOURS = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string RANGE_KM = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string ROUTE_NUMBER = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);


                            
                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `route` SET idRoute = " + idRoute + ", " +
                                    "DURATION_HOURS = " + DURATION_HOURS + ", " +
                                    "RANGE_KM = " + RANGE_KM + ", " +
                                    "ROUTE_NUMBER = " + ROUTE_NUMBER + " " +
                                    "WHERE idRoute = " + idRoute;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "")


                            {
                                string idRoute = Convert.ToString(this.dataGrid.Rows[i].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                                string DURATION_HOURS = Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value);
                                string RANGE_KM = Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value);
                                string ROUTE_NUMBER = Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value);



                                string _comanndString = "UPDATE `route` SET idRoute = " + idRoute + ", " +
                                    "DURATION_HOURS = " + DURATION_HOURS + ", " +
                                    "RANGE_KM = " + RANGE_KM + ", " +
                                    "ROUTE_NUMBER = " + ROUTE_NUMBER + " " +
                                    "WHERE idRoute = " + idRoute;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void отправительToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idSender = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string COUNTRY = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string CITY = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string ADDRESS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string INDEX = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `sender` SET `idSender` = '" + idSender + "', " +
                                "`COUNTRY` = '" + COUNTRY + "', " +
                                "`CITY` = '" + CITY + "', " +
                                "`ADDRESS` = '" + ADDRESS + "', " +
                                "`INDEX` = '" + INDEX + "' " +
                                "WHERE `sender`.`idSender` = " + idSender;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idSender = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                                string COUNTRY = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string CITY = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string ADDRESS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string INDEX = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);


                                string _comanndString = "UPDATE `sender` SET `idSender` = '" + idSender + "', " +
                                "`COUNTRY` = '" + COUNTRY + "', " +
                                "`CITY` = '" + CITY + "', " +
                                "`ADDRESS` = '" + ADDRESS + "', " +
                                "`INDEX` = '" + INDEX + "' " +
                                "WHERE `sender`.`idSender` = " + idSender;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void транспортноеСтредствоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "" )
                        {
                            string idTransport_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                            string idRoute = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string idDrive_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string LOAD_CAPACITY = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string Vehicle_category = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);


                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `transport_vehicle` SET idTransport_vehicle = " + idTransport_vehicle + ", " +
                               "idRoute = " + idRoute + ", " +
                               "idDrive_vehicle = " + idDrive_vehicle + ", " +
                               "LOAD_CAPACITY = " + LOAD_CAPACITY + ", " +
                               "Vehicle_category = " + Vehicle_category + " " +
                               "WHERE idTransport_vehicle = " + idTransport_vehicle;

                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != "")


                            {
                                string idTransport_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                                string idRoute = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string idDrive_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string LOAD_CAPACITY = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string Vehicle_category = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);

                                string _comanndString = "UPDATE `transport_vehicle` SET idTransport_vehicle = " + idTransport_vehicle + ", " +
                                "idRoute = " + idRoute + ", " +
                                "idDrive_vehicle = " + idDrive_vehicle + ", " +
                                "LOAD_CAPACITY = " + LOAD_CAPACITY + ", " +
                                "Vehicle_category = " + Vehicle_category + " " +
                                "WHERE idTransport_vehicle = " + idTransport_vehicle;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void управляющийТранспортнымСредствомToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void управляющийТранспортнымСредствамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "")
                        {
                            string _commandString = "INSERT INTO `drive_vehicle` (`idDrive_vehicle`, `SURNAME`, `NAME`, `MIDDLE_NAME`, `PHONE_NUMBER`, `CATEGORY`, `WORK_EXPERIENCE`) " +
                            "VALUES(@idDrive_vehicle, @SURNAME, @NAME, @MIDDLE_NAME, @PHONE_NUMBER, @CATEGORY, @WORK_EXPERIENCE)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idDrive_vehicle", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@SURNAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@PHONE_NUMBER", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            _command.Parameters.Add("@CATEGORY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[5].Value;
                            _command.Parameters.Add("@WORK_EXPERIENCE", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[6].Value;

                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void отправительToolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void пунктДоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 
   
                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != ""
                     //Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                     //   Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != ""
                     )
                        {
                            string _commandString = "INSERT INTO `point_delivery`(`idPoint_delivery`, `COUNTRY`, `CITY`, `ADDRESS`, `INDEX`) " +
                            "VALUES(@idPoint_delivery, @COUNTRY, @CITY, @ADDRESS, @INDEX)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idPoint_delivery", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@COUNTRY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@ADDRESS", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@INDEX", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void заказToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();//открываем соеденения 

                    //проходим по всем строкам 
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                     Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != ""
                     )
                        {
                            string _commandString = "INSERT INTO `order1`(`idOrder`, `ORDER_DARE`, `DILIVERY_DARE`, `idClient`, `idOperator`, `idPoint_delivery`, `idProduct`, `idSender`, `idTransport_vehicle`) " +
                            "VALUES(@idOrder, @ORDER_DARE, @DILIVERY_DARE, @idClient, @idOperator, @idPoint_delivery, @idProduct, @idSender, @idTransport_vehicle)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);//формируем запрос

                            //меняем заглужки на значения
                            _command.Parameters.Add("@idOrder", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[0].Value;
                            _command.Parameters.Add("@ORDER_DARE", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@DILIVERY_DARE", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@idClient", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@idOperator", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            _command.Parameters.Add("@idPoint_delivery", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[5].Value;
                            _command.Parameters.Add("@idProduct", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[6].Value;
                            _command.Parameters.Add("@idSender", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[7].Value;
                            _command.Parameters.Add("@idTransport_vehicle", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[8].Value;
                            // Здесь наш запрос будет выполнен и данные сохранены в базе данных
                            if (_command.ExecuteNonQuery() != 1)//если хотя бы один не добавился, сообщим об этом
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    else
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                }
                catch
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void клиентToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idClient = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string SURNAME = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string ADDRESS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `client` SET `idClient` = '" + idClient + "', " +
                                "`SURNAME` = '" + SURNAME + "', " +
                                "`NAME` = '" + NAME + "', " +
                                "`ADDRESS` = '" + ADDRESS + "' " +
                                "WHERE `client`.`idClient` = " + idClient;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idClient = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                                string SURNAME = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value);
                                string NAME = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value);
                                string ADDRESS = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value);


                                string _comanndString = "UPDATE `client` SET `idClient` = '" + idClient + "', " +
                                 "`SURNAME` = '" + SURNAME + "', " +
                                 "`NAME` = '" + NAME + "', " +
                                 "`ADDRESS` = '" + ADDRESS + "' " +
                                 "WHERE `client`.`idClient` = " + idClient;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void управляющийТранспортнымСредствомToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idDrive_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string SURNAME = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string MIDDLE_NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string PHONE_NUMBER = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                            string CATEGORY = Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value);
                            string WORK_EXPERIENCE = Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `drive_vehicle` SET `idDrive_vehicle` = '" + idDrive_vehicle + "', " +
                                 "`SURNAME` = '" + SURNAME + "', " +
                                 "`NAME` = '" + NAME + "', " +
                                 "`MIDDLE_NAME` = '" + MIDDLE_NAME + "', " +
                                 "`PHONE_NUMBER` = '" + PHONE_NUMBER + "', " +
                                 "`CATEGORY` = '" + CATEGORY + "', " +
                                 "`WORK_EXPERIENCE` = '" + WORK_EXPERIENCE + "' " +
                                 "WHERE `drive_vehicle`.`idDrive_vehicle` = " + idDrive_vehicle;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idDrive_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                                string SURNAME = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string MIDDLE_NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string PHONE_NUMBER = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                                string CATEGORY = Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value);
                                string WORK_EXPERIENCE = Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value);


                                string _comanndString = "UPDATE `drive_vehicle` SET `idDrive_vehicle` = '" + idDrive_vehicle + "', " +
                                  "`SURNAME` = '" + SURNAME + "', " +
                                  "`NAME` = '" + NAME + "', " +
                                  "`MIDDLE_NAME` = '" + MIDDLE_NAME + "', " +
                                  "`PHONE_NUMBER` = '" + PHONE_NUMBER + "', " +
                                  "`CATEGORY` = '" + CATEGORY + "', " +
                                  "`WORK_EXPERIENCE` = '" + WORK_EXPERIENCE + "' " +
                                  "WHERE `drive_vehicle`.`idDrive_vehicle` = " + idDrive_vehicle;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void операторToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idOperator = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string SURNAME = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string MIDDLE_NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string PHONE_NUMBER = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                           

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `operator` SET `idOperator` = '" + idOperator + "', " +
                                 "`SURNAME` = '" + SURNAME + "', " +
                                 "`NAME` = '" + NAME + "', " +
                                 "`MIDDLE_NAME` = '" + MIDDLE_NAME + "', " +
                                 "`PHONE_NUMBER` = '" + PHONE_NUMBER + "' " +
                                 "WHERE `operator`.`idOperator` = " + idOperator;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idOperator = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                                string SURNAME = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string MIDDLE_NAME = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string PHONE_NUMBER = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                                

                                string _comanndString = "UPDATE `operator` SET `idOperator` = '" + idOperator + "', " +
                                   "`SURNAME` = '" + SURNAME + "', " +
                                   "`NAME` = '" + NAME + "', " +
                                   "`MIDDLE_NAME` = '" + MIDDLE_NAME + "', " +
                                   "`PHONE_NUMBER` = '" + PHONE_NUMBER + "' " +
                                   "WHERE `operator`.`idOperator` = " + idOperator;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void заказToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idOrder = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string ORDER_DARE = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string DILIVERY_DARE = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string idClient = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string idOperator = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                            string idPoint_delivery = Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value);
                            string idProduct = Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value);
                            string idSender = Convert.ToString(this.dataGrid.Rows[0].Cells[7].Value);
                            string idTransport_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[8].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `order1` SET `idOrder` = '" + idOrder + "', " +
                                 "`ORDER_DARE` = '" + ORDER_DARE + "', " +
                                 "`DILIVERY_DARE` = '" + DILIVERY_DARE + "', " +
                                 "`idClient` = '" + idClient + "', " +
                                 "`idOperator` = '" + idOperator + "', " +
                                 "`idPoint_delivery` = '" + idPoint_delivery + "', " +
                                 "`idProduct` = '" + idProduct + "', " +
                                 "`idSender` = '" + idSender + "', " +
                                 "`idTransport_vehicle ` = '" + idTransport_vehicle + "' " +
                                 "WHERE `order1`.`idOrder` = " + idOrder;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idOrder = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                                string ORDER_DARE = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string DILIVERY_DARE = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string idClient = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string idOperator = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                                string idPoint_delivery = Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value);
                                string idProduct = Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value);
                                string idSender = Convert.ToString(this.dataGrid.Rows[0].Cells[7].Value);
                                string idTransport_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[8].Value);


                                string _comanndString = "UPDATE `order1` SET `idOrder` = '" + idOrder + "', " +
                                 "`ORDER_DARE` = '" + ORDER_DARE + "', " +
                                 "`DILIVERY_DARE` = '" + DILIVERY_DARE + "', " +
                                 "`idClient` = '" + idClient + "', " +
                                 "`idOperator` = '" + idOperator + "', " +
                                 "`idPoint_delivery` = '" + idPoint_delivery + "', " +
                                 "`idProduct` = '" + idProduct + "', " +
                                 "`idSender` = '" + idSender + "', " +
                                 "`idTransport_vehicle ` = '" + idTransport_vehicle + "' " +
                                 "WHERE `order1`.`idOrder` = " + idOrder;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void пунктДоставкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin" || user.userName == "editor")
            {
                if (MessageBox.Show("Точно изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 0)
                    {
                        //изменяем данные
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "")
                        {
                            string idPoint_delivery = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                            string COUNTRY = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                            string CITY = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                            string ADDRESS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                            string INDEX = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);

                            //открываем базу данных
                            DatabaseManager _manager = new DatabaseManager();
                            string _comanndString = "UPDATE `point_delivery` SET `idPoint_delivery` = '" + idPoint_delivery + "', " +
                                "`COUNTRY` = '" + COUNTRY + "', " +
                                "`CITY` = '" + CITY + "', " +
                                "`ADDRESS` = '" + ADDRESS + "', " +
                                "`INDEX` = '" + INDEX + "' " +
                                "WHERE `point_delivery`.`idPoint_delivery` = " + idPoint_delivery;
                            MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                            try
                            {
                                _manager.OpenConnection();
                                _command.ExecuteNonQuery();
                                MessageBox.Show("Данные изменены!", "Внимание!");
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
                        else
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                    }
                    else
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        _manager.OpenConnection();
                        bool changed = true;

                        for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                        {
                            if (Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value) != "")
                            {
                                string idPoint_delivery = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                                string COUNTRY = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                                string CITY = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                                string ADDRESS = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                                string INDEX = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);


                                string _comanndString = "UPDATE `point_delivery` SET `idPoint_delivery` = '" + idPoint_delivery + "', " +
                              "`COUNTRY` = '" + COUNTRY + "', " +
                              "`CITY` = '" + CITY + "', " +
                              "`ADDRESS` = '" + ADDRESS + "', " +
                              "`INDEX` = '" + INDEX + "' " +
                              "WHERE `point_delivery`.`idPoint_delivery` = " + idPoint_delivery;
                                MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                                try
                                {
                                    if (_command.ExecuteNonQuery() != 1)
                                        changed = false;
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                                }
                            }
                            else
                                MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }

                        if (changed)
                            MessageBox.Show("Данные изменены!", "Внимание!");
                        else
                            MessageBox.Show("Не все данные изменены!", "Внимание!");

                        _manager.CloseConnection();
                    }
                }
            }
        }

        private void клиентToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idClient = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `client` WHERE `client`.`idClient` = " + idClient;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idClient = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `client` WHERE `client`.`idClient` = " + idClient;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void клиентToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `client`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void управляющийТранспортнымСредствомToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idDrive_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `drive_vehicle` WHERE `drive_vehicle`.`idDrive_vehicle` = " + idDrive_vehicle;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idDrive_vehicle = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `drive_vehicle` WHERE `drive_vehicle`.`idDrive_vehicle` = " + idDrive_vehicle;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void управляющийТранспортнымСредствомToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("DELETE FROM `drive_vehicle`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void операторToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idOperator = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `operator` WHERE `operator`.`idOperator` = " + idOperator;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idOperator = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `operator` WHERE `operator`.`idOperator` = " + idOperator;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void операторToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `operator`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void заказToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idOrder = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `order1` WHERE `order1`.`idOrder` = " + idOrder;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idOrder = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `order1` WHERE `order1`.`idOrder` = " + idOrder;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void заказToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `order1`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void пунктДоставкиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idPoint_delivery = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `point_delivery` WHERE `point_delivery`.`idPoint_delivery` = " + idPoint_delivery;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idPoint_delivery = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `point_delivery` WHERE `point_delivery`.`idPoint_delivery` = " + idPoint_delivery;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void пунктДоставкиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `point_delivery`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void товарToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idProduct = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `product` WHERE `product`.`idProduct` = " + idProduct;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idProduct = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `product` WHERE `product`.`idProduct` = " + idProduct;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void товарToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `product`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void маршрутToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idRoute = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `route` WHERE `route`.`idRoute` = " + idRoute;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idRoute = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `route` WHERE `route`.`idRoute` = " + idRoute;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void маршрутToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `route`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void отправительToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idSender = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `sender` WHERE `sender`.`idSender` = " + idSender;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idSender = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `sender` WHERE `sender`.`idSender` = " + idSender;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void отправительToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `sender`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }

        private void транспортноеСтредствоToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        //открываем базу данных
                        DatabaseManager _manager = new DatabaseManager();
                        string idTransport_vehicle = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string _comanndString = "DELETE FROM `transport_vehicle` WHERE `transport_vehicle`.`idTransport_vehicle` = " + idTransport_vehicle;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные удалены!", "Внимание!");
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
                    else
                    {

                    }
                }
                else
                {
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool delete = true;

                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string idTransport_vehicle = Convert.ToString(row.Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                        string _comanndString = "DELETE FROM `transport_vehicle` WHERE `transport_vehicle`.`idTransport_vehicle` = " + idTransport_vehicle;
                        MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                                delete = false;
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if (delete)
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    else
                        MessageBox.Show("Не все данные удалены!", "Внимание!");

                    _manager.CloseConnection();
                }
            }
        }

        private void транспортноеСтредствоToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (user.userName == "admin")
            {
                if (MessageBox.Show("Точно удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //удаляем данные

                    //открываем базу данных и считываем с нее данные
                    DatabaseManager _manager = new DatabaseManager();
                    MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `transport_vehicle`", _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();

                        //выполянем запрос
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные удалены!", "Внимание!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка удаления данныех!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                }
            }
            else
                MessageBox.Show("Ошибка, у вас нет на это доступа! ", "Ошибка!");
        }
    }
    }


    



