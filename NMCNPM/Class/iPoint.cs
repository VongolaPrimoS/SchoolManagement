using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class iPoint
    {
        private String _nameSubject;
        public String NameSubject
        {
            get { return _nameSubject; }
            set { _nameSubject = value; }
        }

        private String _nameClass;
        public String NameClass
        {
            get { return _nameClass; }
            set { _nameClass = value; }
        }

        private String _grade;
        public String Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        private String _semester;
        public String Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        private String _term;
        public String Term
        {
            get { return _term; }
            set { _term = value; }
        }

        public void LoadData(String NameClass,String NameSubject,String Grade,String Semester,String Term)
        {
            _nameClass = NameClass;
            _nameSubject = NameSubject;
            _semester = Semester;
            _term = Term;
            _grade = Grade;
        }
    }
}
