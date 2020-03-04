using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace OrdersApp.Models
{
    [Table("Tools")]
    public class Tool
    {
        [PrimaryKey, AutoIncrement]
        public string Code { get; set; }
        public string Name { get; set; }
        public string AdditionalInformation { get; set; }
        public string Category { get; set; }
    }
}
