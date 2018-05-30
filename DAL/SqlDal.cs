using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Linq;

namespace DAL
{
    public class SqlDal : IDataAccess
    {
        const string connectionString = @"Server=localhost\sql2014;database=ApprovalRequestsDB;Integrated Security=true;user id=qiaozhi.yang;password=Wow.659465-";
        public override string Get()
        {
            using (var context = ApprovalRequestsDBContext.ApprovalRequestsDBContextFactory.Create(connectionString))
            {
                var result = (from i in context.Businesses
                                where i.RequestType == 1
                                select i).ToList();
                return result.FirstOrDefault().Name;
            }
        }

        public override void SaveInfo()
        {
            RequestHistory rh = new RequestHistory()
            {
                RequestHistoryId = 1,
                RequestId = "a",
                ApprovalStatus = 1,
                Comments="sample",
                UpdatedBy="qiaozhi.yang",
            };
            using (var context = ApprovalRequestsDBContext.ApprovalRequestsDBContextFactory.Create(connectionString))
            {
                context.Add(rh);
                context.SaveChanges();
            }
        }
    }
}
