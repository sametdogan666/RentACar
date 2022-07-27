using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public Int64 ID { get; set; }
        public Int64 UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
