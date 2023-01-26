using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RowOfData_idPoint_delivery
    {
        public object idPoint_delivery { get; set; }
        public object COUNTRY { get; set; }
        public object CITY { get; set; }
        public object ADDRESS { get; set; }
        public object INDEX { get; set; }

        public RowOfData_idPoint_delivery(object _idPoint_delivery, object _COUNTRY, object _CITY, object _ADDRESS, object _INDEX)
        {
            idPoint_delivery = _idPoint_delivery;
            COUNTRY = _COUNTRY;
            CITY = _CITY;
            ADDRESS = _ADDRESS;
            INDEX = _INDEX;
        }
    }
}