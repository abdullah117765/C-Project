using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0.backend
{

    [Serializable]
    internal class Mclass
    {
      
        private string batch_dep;
        private string roomno;
        private string coursename;
        private string classduration;
        private string sem;

        
        public Mclass(string batch_dep1, string roomno1, string coursename1, string classduration1, string sem1)
        {
            Batch_dep = batch_dep1;
            Roomno = roomno1;
            Coursename = coursename1;
            Classduration = classduration1;
            Sem = sem1;
            
        }


        public string Batch_dep { get => batch_dep; set => batch_dep = value; }
        public string Roomno { get => roomno; set => roomno = value; }
        public string Coursename { get => coursename; set => coursename = value; }
        public string Classduration { get => classduration; set => classduration = value; }
        public string Sem { get => sem; set => sem = value; }

       

        
    }


}
