using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entities
{
    public class ProductRatingModel
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
    }
}
