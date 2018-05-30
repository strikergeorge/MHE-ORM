using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace AbstractFactory
{
    public class SQLFactory : AbstractFactory
    {
        public override IDataAccess Create()
        {
            return new SqlDal();
        }
    }
}
