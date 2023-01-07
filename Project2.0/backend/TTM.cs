using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Project2._0.backend
{
    internal class TTM
    {

        Administration a =new Administration();



        // singelton pattern will always return one same object when we make constructor private
        
        private static TTM obj= new TTM();

        public static TTM getinstance() { return obj; }



        private TTM() { 
        
        }




        public int addclass(string batch_dep, string roomno, string coursename, string classduration, string sem,string day)
        {
        int r=   a.addclass( batch_dep,  roomno,  coursename,  classduration,  sem, day);
            return r;
        }

        public LinkedList<Mclass> viewclass(int day)
        {
           
            LinkedList<Mclass> cc = a.viewclass(day);
            return cc;
        }


        public int deleteclass(string batch_dep, string roomno, string coursename, string classduration, string sem, string day)
        {
            int r = a.deleteclass(batch_dep, roomno, coursename, classduration, sem, day);
            return r;

        }

        public int Searchclass(Mclass obj)
        {
            int xx = a.Searchclass(obj);
            return xx;
        }


        public int adduser(string username1, string password1, string email1, string name1)
        {
            int r= a.adduser(username1, password1, email1, name1);
            return r;

        }

        public LinkedList<User> viewuser()
        {
            LinkedList < User > ulist= a.viewuser();
            return ulist;
        }


        public int deleteuser(string s, string pass)
        {
            
           int r= a.deleteuser(s,pass);
            return r;
        }

       

        public int verifyuser(string username, string passward)
        {
            int xx = a.verifyuser(username,passward);
            return xx;

        }

        public int verifyadmin(string username, string passward)
        {
            int xx = a.verifyadmin(username, passward);
            return xx;

        }

        public void writeuser()
        {
            a.writeuser();
        }

        public void readuser()
        {
            a.readuser();
        }



    }
}
