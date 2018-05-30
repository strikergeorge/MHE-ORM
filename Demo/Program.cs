using System;
using DAL;
using BLL;
using AbstractFactory;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbInstance = AbstractFactory.AbstractFactory.CreateFactory("db");
            //var sqlInstance = AbstractFactory.SQLFactory.CreateFactory("sql");
            var dal = dbInstance.Create();

            //dal.SaveInfo();

            Console.WriteLine(dal.Get());
        }
    }
}
