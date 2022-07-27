using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public Int64 ID { get; set; }
        public Int64 CarId { get; set; }
        public Int64 CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
