using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class User
    {
        private String _iUserName;

        public String UserName
        {
            get { return _iUserName; }
            set { _iUserName = value; }
        }
        private String _iPassword;

        public String Password
        {
            get { return _iPassword; }
            set 
            {
                if (value == null)
                {
                    _iPassword = "";
                }
                if (value != "")
                {
                    _iPassword = value;
                } 
            }
        }
        private String _iMaLoai;

        public String MaLoai
        {
            get { return _iMaLoai; }
            set { _iMaLoai = value; }
        }

    }
}
