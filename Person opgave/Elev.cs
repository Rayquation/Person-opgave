using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_opgave
{
    internal class Elev : Person
    {
        private string _Uddanelse;
        private bool _PcmedIskole;
        private StøjEnum _niveau;
        Person p = new Person();

        public Elev()
        {
                
        }
        public Elev(StøjEnum niveau,string uddanelse,bool pc,object obj)
        {
            this.Uddanselse = uddanelse;
            this.Pc = pc;
            this.Niveau = niveau;
            p = (Person)obj;
        }
        public string Uddanselse
        {
            get { return _Uddanelse; }
            set { _Uddanelse = value; }
        }
        public bool Pc
        {
            get { return _PcmedIskole; }
            set { _PcmedIskole = value; }
        }
        public StøjEnum Niveau
        {
            get { return _niveau;}
            set { _niveau = value; }
        }
        public override string ToString()
        {

            return ($"{p.GetFullName()} Du har ikke pc: [{Pc}] Dit støj niveau: [{Niveau}] og din uddanelse er: [{Uddanselse}]");
        }
    }
}
