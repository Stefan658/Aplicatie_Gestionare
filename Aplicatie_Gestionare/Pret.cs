using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produse
{
    class Pret
    {
        private int valoare;
        private int voucherVal;

        // constr implicit
        public  Pret()
        {
            valoare = 0;
        }

        // constr de initializare
        public  Pret (int valoare,int voucher = 0)
        {
            this.valoare = valoare;
        }

        // get set Pret
        void SetPret (int valoare)
        {
            this.valoare = valoare;

        }

        public int getPret()
        {
            return valoare;
        }

        // get set Voucher

        void SetVoucher(int vVal)
        {
           if(vVal>0 && vVal<80)
                voucherVal = vVal;
           else
            {
                Console.WriteLine("\nValoarea data nu este posibila!");
            }

        }
        public int getVoucher()
        {
            return voucherVal;
        }

        // METODA aplicare voucher
        public float voucher()
        {
            if (voucherVal != 0)
                return (voucherVal / 100) * valoare;
            else return valoare;
        } 
          
        
    }
}
