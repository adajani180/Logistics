using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Logistics.Areas.Transactions.Models
{
    public class TransactionsContext : DbContext
    {
        public TransactionsContext() : base("name=SatisDB")
        {
        }

    }
}