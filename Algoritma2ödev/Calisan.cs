using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma2ödev
{
    public abstract class Calisan
    {
        public string TC;
        public string isim;
        public string soyisim;




        public Calisan(string isim, string soyisim, string TC)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.TC = TC;


        }


        public abstract decimal Kazanc();


        public static decimal operator +(Calisan a, Calisan b)
        {


            return a.Kazanc() + b.Kazanc();
        }
        public static decimal operator -(Calisan a, Calisan b)
        {



            decimal maasFarkı =a.Kazanc() - b.Kazanc();

            return maasFarkı;
        }
        public static decimal operator *(Calisan a, Calisan b)
        {



            decimal maasCarp = a.Kazanc() * b.Kazanc();
            return maasCarp;
        }
        public static double operator /(Calisan a, Calisan b)
        {




            double maasBol = Convert.ToDouble(a.Kazanc() / b.Kazanc());
            return maasBol;

        }
        public static bool operator ==(Calisan a, Calisan b)
        {
            if (a.isim == b.isim && a.soyisim == b.soyisim && a.TC == b.TC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Calisan a, Calisan b)
        {



            if (a.isim != b.isim && a.soyisim != b.soyisim && a.TC != b.TC)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(Calisan a, Calisan b)
        {



            if (a.Kazanc() > b.Kazanc())
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static bool operator <(Calisan a, Calisan b)
        {



            if (a.Kazanc() < b.Kazanc())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Calisan a, Calisan b)
        {

            if (a.Kazanc() >= b.Kazanc())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <=(Calisan a, Calisan b)
        {

            if (a.Kazanc() <= b.Kazanc())
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }

    class MaasliCalisan : Calisan
    {


        public decimal Maas { get; set; }
       

        public MaasliCalisan(string isim, string soyisim, string TC, decimal Maas) : base(isim, soyisim, TC)
        {

            this.Maas = Maas;

        }

        public override decimal Kazanc()
        {

            return Maas;
        }


    }

    class KomisyonluCalisan : Calisan
    {
        double KomisyonOrani;
        decimal ToplamSatis;



        

        public KomisyonluCalisan(string isim, string soyisim, string TC, double KomisyonOrani, decimal ToplamSatis) : base(isim, soyisim, TC)
        {
            this.KomisyonOrani = KomisyonOrani;
            this.ToplamSatis = ToplamSatis;
        }

        public override decimal Kazanc()
        {

            return ToplamSatis * Convert.ToDecimal(KomisyonOrani);


        }
    }

    class SaatlikCalisan : Calisan
    {
        decimal SaatlikUcret;
        int CalisilanSaat;



      

        public SaatlikCalisan(string isim, string soyisim, string TC, decimal SaatlikUcret, int CalisilanSaat) : base(isim, soyisim, TC)
        {
            this.SaatlikUcret = SaatlikUcret;
            this.CalisilanSaat = CalisilanSaat;
        }

        public override decimal Kazanc()
        {

            return SaatlikUcret * Convert.ToDecimal(CalisilanSaat);


        }

    }

}
