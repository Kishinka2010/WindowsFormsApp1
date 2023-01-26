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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private List<RowOfData_idProduct> _data = new List<RowOfData_idProduct>();
        private List<RowOfData_idTransport_vehicle> _data_tr = new List<RowOfData_idTransport_vehicle>();
        private List<RowOfData_idRoute> _data_rout = new List<RowOfData_idRoute>();
        private List<RowOfData_idSender> _data_sen = new List<RowOfData_idSender>();
        private void HeaderOfTheTable_Search_Id()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Товары дешевле данной суммы в $"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "PRICE"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            dataGrid.Columns.Add(column1);
            dataGrid.ReadOnly = false;
        }

        private void HeaderOfTheTable_Search_BetDate()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Протяженнность маршрута от"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "RANGE_KM_o"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "до (КМ)";
            column2.Width = 100;
            column2.Name = "RANGE_KM_d";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.ReadOnly = false;
        }

        private void HeaderOfTheTable_Search_Sen()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Поиск отправителей с одного города"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "CITY"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.ReadOnly = false;
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            dataGrid.Columns.Add(column1);
            dataGrid.ReadOnly = false;
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
            dataGrid.ReadOnly = false;//запрещаем пользователю изменять данные (!!!)
        }

        private void HeaderOfTheTable_Product()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id товара"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.Name = "idProduct"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

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

        private void AddDataGrid_Product(RowOfData_idProduct row)
        {
            dataGrid.Rows.Add(row.idProduct, row.WEIGHT, row.OVERALL_DIMENSIONS, row.PRODUCT_CHARACTERISTICS, row.PRICE);//добавляем строку в таблицу
        }

        private void AddDataGrid_Route(RowOfData_idRoute row)
        {
            dataGrid.Rows.Add(row.idRoute, row.DURATION_HOURS, row.RANGE_KM, row.ROUTE_NUMBER);//добавляем строку в таблицу
        }

        private void AddDataGrid_Sender(RowOfData_idSender row)
        {
            dataGrid.Rows.Add(row.idSender, row.COUNTRY, row.CITY, row.ADDRESS_S, row.INDEX);//добавляем строку в таблицу
        }

        private List<RowOfData_idProduct> _data_pr = new List<RowOfData_idProduct>();//создаем список данных

        private void SearchIpProd_Click(object sender, EventArgs e)
        {
            MySqlDataReader _reader;
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    string PRICE = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id                    
                    //открываем базу данных
                    DatabaseManager _manager = new DatabaseManager();
                    string _comanndString = "SELECT * FROM `product` WHERE PRICE <" + PRICE;
                    MySqlCommand _command = new MySqlCommand(_comanndString, _manager.GetConnection);

                    try
                    {
                        _manager.OpenConnection();
                        _command.ExecuteNonQuery();
                        MessageBox.Show("Данные найдены!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager.CloseConnection();
                    }
                    _manager.OpenConnection();
                    _reader = _command.ExecuteReader();
                    dataGrid.DataSource = null;
                    dataGrid.Columns.Clear();
                    dataGrid.Rows.Clear();
                    dataGrid.ReadOnly = false;
                    HeaderOfTheTable_Product();
                    while (_reader.Read())
                    {
                        //заполняем данные
                        RowOfData_idProduct row = new RowOfData_idProduct(_reader["idProduct"], _reader["WEIGHT"], _reader["OVERALL_DIMENSIONS"], _reader["PRODUCT_CHARACTERISTICS"], _reader["PRICE"]);
                        _data.Add(row);
                    }

                    //добавляем в таблицу данные
                    for (int i = 0; i < _data.Count; i++)
                        AddDataGrid_Product(_data[i]);
                    break;
                case 1:
                    string RANGE_KM_o = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id  
                    string RANGE_KM_d = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);//так как id не меняются, то в таблице указаны нужные id  
                    

                    //открываем базу данных
                    DatabaseManager _manager_date = new DatabaseManager();
                    string _comanndString_date = "SELECT * FROM `route` WHERE RANGE_KM BETWEEN '" + RANGE_KM_o + "' and '" + RANGE_KM_d + "'" ;
                    MySqlCommand _command_date = new MySqlCommand(_comanndString_date, _manager_date.GetConnection);

                    try
                    {
                        _manager_date.OpenConnection();
                        _command_date.ExecuteNonQuery();
                        MessageBox.Show("Данные найдены!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_date.CloseConnection();
                    }
                    _manager_date.OpenConnection();
                    _reader = _command_date.ExecuteReader();
                    dataGrid.DataSource = null;
                    dataGrid.Columns.Clear();
                    dataGrid.Rows.Clear();
                    dataGrid.ReadOnly = false;
                    HeaderOfTheTable_Route();
                    while (_reader.Read())
                    {
                        //заполняем данные
                        RowOfData_idRoute row = new RowOfData_idRoute(_reader["idRoute"], _reader["DURATION_HOURS"], _reader["RANGE_KM"], _reader["ROUTE_NUMBER"]);
                        _data_rout.Add(row);
                    }

                    //добавляем в таблицу данные
                    for (int i = 0; i < _data_rout.Count; i++)
                        AddDataGrid_Route(_data_rout[i]);
                    break;
                case 2:
                    string CITY = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);//так как id не меняются, то в таблице указаны нужные id                    
                    //открываем базу данных
                    DatabaseManager _manager_sen = new DatabaseManager();
                    string _comanndString_sen = "SELECT * FROM `sender` WHERE CITY = '" + CITY + "'";
                    MySqlCommand _command_sen = new MySqlCommand(_comanndString_sen, _manager_sen.GetConnection);

                    try
                    {
                        _manager_sen.OpenConnection();
                        _command_sen.ExecuteNonQuery();
                        MessageBox.Show("Данные найдены!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                    }
                    finally
                    {
                        _manager_sen.CloseConnection();
                    }
                    _manager_sen.OpenConnection();
                    _reader = _command_sen.ExecuteReader();
                    dataGrid.DataSource = null;
                    dataGrid.Columns.Clear();
                    dataGrid.Rows.Clear();
                    dataGrid.ReadOnly = false;
                    HeaderOfTheTable_Sender();
                    while (_reader.Read())
                    {
                        //заполняем данные
                        RowOfData_idSender row = new RowOfData_idSender(_reader["idSender"], _reader["COUNTRY"], _reader["CITY"], _reader["ADDRESS"], _reader["INDEX"]);
                        _data_sen.Add(row);
                    }

                    //добавляем в таблицу данные
                    for (int i = 0; i < _data_sen.Count; i++)
                        AddDataGrid_Sender(_data_sen[i]);
                    break;
                case 3:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Поиск по товарам дешевле данной суммы в $")
            {
                dataGrid.Columns.Clear();
                HeaderOfTheTable_Search_Id();
                dataGrid.ReadOnly = false;
            }
            else if (comboBox1.Text == "Поиск по протяженнности маршрута")
            {
                dataGrid.Columns.Clear();
                HeaderOfTheTable_Search_BetDate();
                dataGrid.ReadOnly = false;

            }
            else if (comboBox1.Text == "Поиск отправителей с одного города")
            {
                dataGrid.Columns.Clear();
                HeaderOfTheTable_Search_Sen();
                dataGrid.ReadOnly = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            this.Hide();
            form.Show();
        }

      
        private void SearchForm_Load(object sender, EventArgs e)
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

        private void выходИзПрограммыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            this.Hide();
            form.Show();
        }

        private void выходВОкноРегестрацииToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
