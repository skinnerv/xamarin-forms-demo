using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinFormsDemo.Models.PoopTracker
{
    class Medication
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
    }
}
