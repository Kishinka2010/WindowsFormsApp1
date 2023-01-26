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
    class RowOfData_idTransport_vehicle
    {


        public object idTransport_vehicle { get; set; }
        public object idRoute { get; set; }
        public object idDrive_vehicle { get; set; }
        public object LOAD_CAPACITY { get; set; }
        public object Vehicle_category { get; set; }


        //конструкторы класса
        public RowOfData_idTransport_vehicle(object _idTransport_vehicle, object _idRoute, object _idDrive_vehicle, object _LOAD_CAPACITY, object _Vehicle_category) 
        {
            idTransport_vehicle = _idTransport_vehicle;
            idRoute = _idRoute;
            idDrive_vehicle = _idDrive_vehicle;
            LOAD_CAPACITY = _LOAD_CAPACITY;
            Vehicle_category = _Vehicle_category;
        }



    }
}
