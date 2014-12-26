using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class ClassRoom
    {
        private String _idClass;
        public String IdClass
        {
            get { return _idClass; }
            set { _idClass = value; }
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

        private String _sum;
        public String Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        private String _teacher;
        public String Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
    }
}
