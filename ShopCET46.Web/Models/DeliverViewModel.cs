using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopCET46.Web.Models
{
    public class DeliverViewModel
    {

        public int Id { get; set; }



        [DisplayName("Order date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime DeliveryDate { get; set; }
    }
}
