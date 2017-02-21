using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinExWebApp20328991.Models
{
    [Table("Destination")]
    public class Destination
    {   public virtual int DestinationID { get; set; }
        public string City { get; set; }
        public virtual string CurrencyCode { get; set; }
        public string ProvinceCode { get; set; }
    }
}