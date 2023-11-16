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
        public string Code { get; set; }
        public string N { get; set; }
        public double Pr {get;set;}
        //Costruttore
        public Articolo(string code, string n, double pr)
        {
            Code = code;
            N = n;
            Pr = pr;
        }
        public virtual void sconto_pr(bool fedeltà)
        {
            if (fedeltà)
            {
                Pr *= 0.95;
            }
        }
        public void scadenza()
        {

        }
    }
}
