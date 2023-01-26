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
    class RowOfData_idSender
    {
        public object idSender { get; set; }
        public object COUNTRY { get; set; }
        public object CITY { get; set; }
        public object ADDRESS_S { get; set; }
        public object INDEX { get; set; }

        public RowOfData_idSender(object _idSender, object _COUNTRY, object _CITY, object _ADDRESS_S, object _INDEX) 
        {
            idSender = _idSender;
            COUNTRY = _COUNTRY;
            CITY = _CITY;
            ADDRESS_S = _ADDRESS_S;
            INDEX = _INDEX;
        }
    }
}
