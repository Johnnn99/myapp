using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Vocabs
    {
        String engVocabs, vocabs;
        public Vocabs(String ev, String v)
        {
            engVocabs = ev;
            vocabs = v;
        }
        public String EngVocabs
        {
            get
            {
                return engVocabs;
            }
            set
            {
                engVocabs = value;
            }
        }
        public String OtherVocabs
        {
            get
            {
                return vocabs;
            }
            set
            {
                vocabs = value;
            }
        }
    }
}
