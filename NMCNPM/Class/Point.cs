using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class Point
    {
        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private float _preTest;
        public float PreTest
        {
            get { return _preTest; }
            set { _preTest = value; }
        }

        private float _midTest;
        public float MidTest
        {
            get { return _midTest; }
            set { _midTest = value; }
        }

        private float _finalTest;
        public float FinalTest
        {
            get { return _finalTest; }
            set { _finalTest = value; }
        }


    }
}
