using System;
using System.Collections.Generic;
using System.Text;

namespace IDAL
{
    public abstract class IDataAccess
    {
        public abstract string Get();//抽象的方法 ，dal实例需要符合的契约

        public abstract void SaveInfo();
    }
}
