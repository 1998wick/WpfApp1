using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class Payment
    {
        public int PaymentId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Paydate { get; set; }
    }
}
