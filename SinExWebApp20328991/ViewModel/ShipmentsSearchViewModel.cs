using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinExWebApp20328991.ViewModel
{
    public class ShipmentsSearchViewModel
    {
        public virtual int ShippingAccountId { get; set; }
        public virtual List<SelectListItem> ShippingAccounts { get; set; }
    }
}