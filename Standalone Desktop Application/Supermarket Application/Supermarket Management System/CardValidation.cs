using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class CardValidation : Exception
    {
        String CardType;
        public CardValidation(String cardtype)
        {
            CardType = cardtype;
        }
        public void Validation()
        {
            MessageBox.Show( CardType+ " is not valid " , "Warning message");
        }
    }
}
