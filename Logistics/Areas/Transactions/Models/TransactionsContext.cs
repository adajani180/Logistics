using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int Id { get; set; }

        //[ForeignKey()]
        public int ItemNum { get; set; }

        //[ForeignKey()]
        public int EquipNum { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string EmployeeId { get; set; }

        //[ForeignKey()]
        public int NewEmployeeId { get; set; }
        public string Vin { get; set; }
        public string UnitId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}