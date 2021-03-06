﻿using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DAL
{
    public class DbContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext dbContext = CallContext.GetData("dbContext") as DbContext;
            if (dbContext == null)
            {
                dbContext = new OracleDbContext();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
