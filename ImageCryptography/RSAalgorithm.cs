using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;

namespace ImageCrypto
{
    class RSAalgorithm
    {

        public static long square(long a)
        {
            return (a * a);
        }

        public static long BigMod(int b, int p, int m) //b^p%m=?
        {
            if (p == 0)
                return 1;
            else if (p % 2 == 0)
                return square(BigMod(b, p / 2, m)) % m;
            else
                return ((b % m) * BigMod(b, p - 1, m)) % m;
        }

        public static int n_value(int prime1, int prime2) 
        {
            return( prime1 * prime2);
        }

        public static int cal_phi(int prime1, int prime2)
        { 
            return ( (prime1 - 1) * (prime2- 1) );
        }

        public static Int32 cal_privateKey(int phi, int e, int n )
        {             
            int d = 0 ;
            int RES = 0;

            for (d = 1; ; d++)
            {
                RES = (d * e) % phi;
                if (RES == 1) break;
            }
            return d;
        }

        
    }
}
