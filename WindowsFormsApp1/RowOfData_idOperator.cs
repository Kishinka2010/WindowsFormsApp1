using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RowOfData_idOperator
    {
        public object idOperator { get; set; }
        public object SURNAME { get; set; }
        public object NAME { get; set; }
        public object MIDDLE_NAME { get; set; }
        public object PHONE_NUMBER { get; set; }

        public RowOfData_idOperator(object _idOperator, object _SURNAME, object _NAME, object _MIDDLE_NAME, object _PHONE_NUMBER)
        {
            idOperator = _idOperator;
            SURNAME = _SURNAME;
            NAME = _NAME;
            MIDDLE_NAME = _MIDDLE_NAME;
            PHONE_NUMBER = _PHONE_NUMBER;
        }
    }
}
