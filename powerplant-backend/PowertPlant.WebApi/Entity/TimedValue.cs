using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowertPlant.WebApi.Entity
{
    public class TimedValue
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Guid webid { get; set; }
        public DateTime timestamp { get; set; }
        public int value { get; set; }
        
    }
}
