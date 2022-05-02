using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_opgave
{
    internal class Person : IComparable
    {
        private string fornavn;
        private string efternavn;
        private double højde;
        private int vægt;

        public Person()
        {
        }
        public Person(string fornavn,string efternavn,double højde,int vægt)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Højde = højde;
            this.Vægt = vægt;
        }
        public Person(string fornavn,string efternavn)
        {
            this.Fornavn=fornavn;
            this.Efternavn = efternavn;
        }

        public string Fornavn
        {
            get { return fornavn; }
            set { fornavn = value; }
        }

        public string Efternavn
        {
            get { return efternavn; }
            set { efternavn = value; }
        }

        public double Højde
        {
            get { return højde; }
            set { højde = value; }
        }

        public int Vægt
        {
            get { return vægt; }
            set { vægt = value; }
        }
        public double GetBMI()
        {
            double HøjdeIMeter = højde / 100;
            double BMI = Vægt/Math.Pow(HøjdeIMeter, 2);
            return BMI;
        }
        public string GetFullName()
        {
            return $"{Fornavn} {Efternavn}";
        }
        public override string ToString()
        {
            
            return ($"{GetFullName()} du vejer {Vægt}kg og er {(double)Højde/100}m høj og din bmi er {GetBMI()}");
        }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            double rounded = this.GetBMI()-p.GetBMI();
            if ((this.GetBMI() - p.GetBMI()) > 0)
            {
                return 1;
            }else if ((this.GetBMI() - p.GetBMI()) < 0)
            {
                return -1;
            }else
            {
                return 0;
            }
        }
    }
}
