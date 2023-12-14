using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlXML
{
    public class Search
    {
        #region init
        public string nameC = null;
        public string faculty = null;
        public string day = null;
        public string leader = null;
        public string orientation = null;
        internal string name;
        #endregion init
        public Search()
        {

        }
        #region Comparison
        public bool Compare(Search obj)
        {
            if ((this.leader == obj.leader) &&
                (this.faculty == obj.faculty) &&
               (this.day == obj.day) &&
               (this.nameC == obj.nameC) &&
               (this.orientation == obj.orientation))
            {
                return true;
            }
            else return false;
        }
        #endregion  Comparison
    }
}
