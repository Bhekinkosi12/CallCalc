using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallCalc
{
    [Table("Consumed")]
    public class Consumed
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public double TotallCall { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
    }
}
