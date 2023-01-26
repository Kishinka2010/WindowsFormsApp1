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
    class RowOfData_idRoute
    {
        public object idRoute { get; set; }
        public object DURATION_HOURS { get; set; }
        public object RANGE_KM { get; set; }
        public object ROUTE_NUMBER { get; set; }

        //конструкторы класса

        public RowOfData_idRoute(object _idRoute, object _DURATION_HOURS, object _RANGE_KM, object _ROUTE_NUMBER)
        {
            idRoute = _idRoute;
            DURATION_HOURS = _DURATION_HOURS;
            RANGE_KM = _RANGE_KM;
            ROUTE_NUMBER = _ROUTE_NUMBER;
        }
    }
}
