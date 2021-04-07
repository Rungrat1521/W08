using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataGridView
{
    class Album
    {
        private string newalbum;
        private string newartist;
        private string newtitle;
        private string newtrack;
        private string newdate1;


        public Album() { }

        public Album(string ab, string at, string tt, string t, string d)
        {
            this.newalbum = ab;
            this.newartist = at;
            this.newtitle = tt;
            this.newtrack = t;
            this.newdate1 = d;

        }
        public string Newalbum { get => newalbum; set => newalbum = value; }
        public string Newartist { get => newartist; set => newartist = value; }
        public string Newtitle { get => newtitle; set => newtitle = value; }
        public string Newtrack { get => newtrack; set => newtrack = value; }
        public string Newdate1 { get => newdate1; set => newdate1 = value; }

        public string[] aa = { "Luxury Elite", "Luxury Elite", "S.W.A.K",
            "1", "11/2/1988" };
        public string[] bb = { "Drive Slow", "Windows 96", "Windows 96",
            "2", "12/4/1990" };
        public string[] cc = { "Indigo Plateau!", "Maitro", "Indigo Plateau!",
            "3", "02/01/2002" };
        public string[] dd = { "Luxury Elite Radio", "Luxury Elite", "You Can Sense It",
            "4", "04/07/2010" };
        public string[] ee = { "dreamy night", "Lilypichu", "dreamy night",
            "5", "17/12/2018" };
        public string[] ff = { "TV Party", "Luxury Elite", "Cruise",
            "6", "15/11/2005" };


    }









        /*public string[] rows = 
        {"Luxury Elite", "Luxury Elite", "S.W.A.K",
            "1", "11/2/1988" };*/
    
}
