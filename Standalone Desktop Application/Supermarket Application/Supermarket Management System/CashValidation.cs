using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class CashValidation :Exception
    {
        decimal Payment;
        public CashValidation(decimal payment)
        {
            Payment = payment;
        }
        public void Validation()
        {
            MessageBox.Show(Payment.ToString() +"Rs is insufficient amount","Warning message");
        }

    }
}
