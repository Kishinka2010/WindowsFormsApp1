using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    /*
     * Этот класс будет описывать одну строку данных
     * Так будет удобнее передавать в метод добавления данных
     */
    class RowOfData
    {
        //тут перечисляем поля, которые указаны в базе данных
        public object idClient { get; set; }
        public object SURNAME { get; set; }
        public object NAME { get; set; }
        public object ADDRESS { get; set; }


        //конструкторы класса
        public RowOfData() { }
        public RowOfData(object _idClient, object _SURNAME, object _NAME, object _ADDRESS)
        {
            idClient = _idClient;
            SURNAME = _SURNAME;
            NAME = _NAME;
            ADDRESS = _ADDRESS;





        }

        //методы класса
        public void DataChange(object _idClient, object _SURNAME, object _NAME, object _ADDRESS)
        {
            idClient = _idClient;
            SURNAME = _SURNAME;
            NAME = _NAME;
            ADDRESS = _ADDRESS;
        }
    }
}
