using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS314App_ahenry
{
    public class AddUserDataMgr : DataMgr
    {
        public List<AddUserData> userDataList = new List<AddUserData>();

        public AddUserDataMgr(string fileName) : base(fileName)
        {
            // things here:
        }
    }
}
