using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RowOfData_idDrive_vehicle
    {
        public object idDrive_vehicle { get; set; }
        public object SURNAME { get; set; }
        public object NAME { get; set; }
        public object MIDDLE_NAME { get; set; }
        public object PHONE_NUMBER { get; set; }
        public object CATEGORY { get; set; }
        public object WORK_EXPERIENCE { get; set; }


        public RowOfData_idDrive_vehicle(object _idDrive_vehicle, object _SURNAME, object _NAME, object _MIDDLE_NAME, object _PHONE_NUMBER, object _CATEGORY, object _WORK_EXPERIENCE)
        {
            idDrive_vehicle = _idDrive_vehicle;
            SURNAME = _SURNAME;
            NAME = _NAME;
            MIDDLE_NAME = _MIDDLE_NAME;
            PHONE_NUMBER = _PHONE_NUMBER;
            CATEGORY = _CATEGORY;
            WORK_EXPERIENCE = _WORK_EXPERIENCE;

        }
    }
}