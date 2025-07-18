using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS314App_ahenry
{
    public class ModifyUserDataMgr : DataMgr
    {
        public List<ModifyUserData> ModifyUserDataList = new List<ModifyUserData>();

        public ModifyUserDataMgr(string fileName) : base(fileName)
        {
            // things
        }
    }
}
