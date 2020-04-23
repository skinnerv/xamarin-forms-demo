using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace XamarinFormsDemo.Models
{
    class Covid19StatsItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int TotalConfirmed { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalRecovered { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
    }
}
