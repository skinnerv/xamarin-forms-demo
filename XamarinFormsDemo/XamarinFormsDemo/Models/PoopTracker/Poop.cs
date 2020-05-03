using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinFormsDemo.Models.PoopTracker
{
    public class Poop
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public byte Type { get; set; }
        public byte Size { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
    }
}
