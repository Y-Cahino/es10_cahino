using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace es10_cahino
{

    class Articolo
    {
        protected int code;
        protected string n;
        protected double pr;
        //Costruttore
        public Articolo(int code, string n, double pr)
        {
            this.code = code;
            this.n = n;
            this.pr = pr;
        }
        public void sconta()
        {

        }
    }
}
