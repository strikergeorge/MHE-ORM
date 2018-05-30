using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Reflection;
using DAL;



namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        //抽象工厂获取web中app.config的key-value根据value的值判断创建指定的工厂
        public static AbstractFactory CreateFactory(string factoryName)
        {
            string FactoryName = Constants.MS_SQL_LOCAL_DB;//保证常量中的值和MONGIFactory或者SQLFactory相同
            AbstractFactory Instance;
            if (FactoryName != null || FactoryName != "")
            {
                Instance = (AbstractFactory)Assembly.Load(FactoryName).CreateInstance(FactoryName);
            }
            else
            {
                Instance = null;
            }
            return Instance;
        }

        public abstract IDataAccess Create();
    }
}
