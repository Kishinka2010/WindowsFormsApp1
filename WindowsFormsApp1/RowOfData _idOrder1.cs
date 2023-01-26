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
    class RowOfDataid_Order1
    {
        public object idOrder { get; set; }
        public object ORDER_DARE { get; set; }
        public object DILIVERY_DARE { get; set; }
        public object idClient { get; set; }
        public object idOperator { get; set; }
        public object idPoint_delivery { get; set; }
        public object idProduct { get; set; }
        public object idSender { get; set; }
        public object idTransport_vehicle { get; set; }


        public RowOfDataid_Order1(object _idOrder, object _ORDER_DARE, object _DILIVERY_DARE, object _idClient, object _idOperator, object _idPoint_delivery, object _idProduct, object _idSender, object _idTransport_vehicle)
        {
            idOrder = _idOrder;
            ORDER_DARE = _ORDER_DARE;
            DILIVERY_DARE = _DILIVERY_DARE;
            idClient = _idClient;
            idOperator = _idOperator;
            idPoint_delivery = _idPoint_delivery;
            idProduct = _idProduct;
            idSender = _idSender;
            idTransport_vehicle = _idTransport_vehicle;
        }
    }
}
