using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    [Serializable]

    public class person
    {
        public string Name;
        public string Adress;
        public string Job;
        public string Education;
        public string Rank;
        public string DateRank;
        public string Post;
        public string Unit;
        public string ServiceForm;
        public string ServicePeriod;
        public string Character;

        public person(string n, string a, string j, string e, string r, string d, string p, string u, string sf, string sp, string c)
        {
            Name = n;
            Adress = a;
            Job = j;
            Education = e;
            Rank = r;
            DateRank = d;
            Post = p;
            Unit = u;
            ServiceForm = sf;
            ServicePeriod = sp;
            Character = c;
        }

        public person() { }
    }
}
