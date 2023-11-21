using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace es10_cahino
{

    public class Articolo
    {
        public string Code { get; set; }
        public string N { get; set; }
        public double Pr { get; set; }
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
        public virtual int data_sc(int Scadenza)
        {
            Scadenza = DateTime.Now.Year;
            Random r= new Random();
            int AddA = r.Next(0, 10);
            int aCasual=Scadenza+ AddA;
            return aCasual;
        }
    }
    class Alimentare : Articolo
    {
        public int Scadenza { get; set; }
        public Alimentare(string code, string n, double pr, int scadenza) : base(code, n, pr)
        {
            Scadenza = scadenza;
        }
        public override void sconto_pr(bool fedeltà)
        {
            base.sconto_pr(fedeltà);
            if (Scadenza == DateTime.Now.Year)
            {
                Pr *= 0.8;
            }
        }
    }
    class AlimentareFr : Articolo
    {
        public int Gconsumo { get; set; }
        public AlimentareFr(string code, string n, double pr, int gconsumo) : base(code, n, pr)
        {
            Gconsumo = gconsumo;
        }
        public override void sconto_pr(bool fedeltà)
        {
            base.sconto_pr(fedeltà);
            double sconto = Gconsumo * 2;
            Pr *= (1 - sconto / 100);
        }
    }
    class NonAlimentare : Articolo
    {
        public string Materiale { get; set; }
        public bool Rici { get; set; }
        public NonAlimentare(string code, string n, double pr, bool rici) : base(code, n, pr)
        {
            Rici = rici;
        }
        public override void sconto_pr(bool fedeltà)
        {
            base.sconto_pr(fedeltà);
            if (Rici)
            {
                Pr *= 0.9;
            }
        }

    }
}
