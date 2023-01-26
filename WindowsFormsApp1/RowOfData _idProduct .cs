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
    class RowOfData_idProduct
    {
        public object idProduct { get; set; }
        public object WEIGHT { get; set; }
        public object OVERALL_DIMENSIONS { get; set; }
        public object PRODUCT_CHARACTERISTICS { get; set; }
        public object PRICE { get; set; }

        public RowOfData_idProduct(object _idProduct, object _WEIGHT, object _OVERALL_DIMENSIONS, object _PRODUCT_CHARACTERISTICS, object _PRICE) 
        {
            idProduct = _idProduct;
            WEIGHT = _WEIGHT;
            OVERALL_DIMENSIONS = _OVERALL_DIMENSIONS;
            PRODUCT_CHARACTERISTICS = _PRODUCT_CHARACTERISTICS;
            PRICE = _PRICE;
        }
    }
}
