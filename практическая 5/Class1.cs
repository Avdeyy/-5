using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_5
{
    class StudentOfISIT
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set // генерация ошибки в случае: задают имя, которое уже задано
            {
                if (String.IsNullOrEmpty(_name))
                {
                    _name = value;

                }
                else
                {
                    throw new Exception();
                }
            }
        }
        private string _speciality;
        public string Speciality
        {
            get { return _speciality; }
            set // генерация ошибки в случае: задают имя, которое уже задано
            {
                if (String.IsNullOrEmpty(_speciality))
                {
                    _speciality = value;

                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public int ScholarshipAmount { get; set; }
        public int Check { get; set; }
        public bool Warning
        {
            get
            {
                return Check < 100;
            }
        }

        public bool Scholarshipwarning { get; set; }
    }
}
