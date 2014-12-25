using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class Term
    {
        private String _idTerm;
        public String IdTerm
        {
            get { return _idTerm; }
            set { _idTerm = value; }
        }

        private String _nameTerm;
        public String NameTerm
        {
            get { return _nameTerm; }
            set { _nameTerm = value; }
        }
    }
}
