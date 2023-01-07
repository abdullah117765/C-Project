using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
namespace Project2._0.backend
{
    internal class Administration
    {
        private string username = "jojo";
        private string password = "jojo";
        public int ttsize = 5;

        // storing my classes in implemented linked list
        LinkedList<TimeTable> tlist = new LinkedList<TimeTable>();
        LinkedList<User> ulist = new LinkedList<User>();

        TimeTable t1 = new TimeTable("9", 1);// 1 statnds for monday
        TimeTable t2 = new TimeTable("9", 2);// 2 stands for tuesday
        TimeTable t3 = new TimeTable("9", 3);// 3 stands for wednesday
        TimeTable t4 = new TimeTable("9", 4);// 4 for thursday
        TimeTable t5 = new TimeTable("9", 5);// 5 for friday


       


        public Administration()
        {
            
           // wr.read();
            
            // intitizlizing that the timetable will be of 5 days
            tlist.AddLast(t1);
            tlist.AddLast(t2);
            tlist.AddLast(t3);
            tlist.AddLast(t4);
            tlist.AddLast(t5);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }



        public int verifyadmin(string username1, string passward)
        {
           if(password== passward  && username == username1)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }




        public int addclass(string batch_dep, string roomno, string coursename, string classduration, string sem, string day1)
        {
            int r;
            int day = Int16.Parse(day1);

           

            if (day>0  && day < 6)
            {
                TimeTable c = tlist.ElementAt(day-1);
                r = c.addclass1(batch_dep, roomno, coursename, classduration, sem, day1);
               
                return r;
            }
            else
            {
                return -2; // means that wrong day was selected
            }
            
        }

        public LinkedList<Mclass> viewclass(int day)
        {
            


            switch(day)
            {
                case 1:
                    {
                        TimeTable c = tlist.Find(t1).Value;
                        LinkedList<Mclass> cc = c.viewclass();
                        return cc;


                        break;
                    }

                case 2:
                    {

                        TimeTable c = tlist.Find(t2).Value;
                        LinkedList<Mclass> cc = c.viewclass();
                        return cc;

                        break;
                    }

                case 3:
                    {

                        TimeTable c = tlist.Find(t3).Value;
                        LinkedList<Mclass> cc = c.viewclass();
                        return cc;

                        break;
                    }

                case 4:
                    {
                        TimeTable c = tlist.Find(t4).Value;
                        LinkedList<Mclass> cc = c.viewclass();
                        return cc;


                        break;
                    }

                case 5:
                    {

                        TimeTable c = tlist.Find(t5).Value;
                        LinkedList<Mclass> cc = c.viewclass();
                        return cc;

                        break;
                    }

            }
            LinkedList<Mclass> view= new LinkedList<Mclass>();
            return view;

        }


        public int deleteclass(string batch_dep, string roomno, string coursename, string classduration, string sem, string day1)
        {
            

            int r;
            int day = Int16.Parse(day1);



            if (day > 0 && day < 6)
            {
                TimeTable c = tlist.ElementAt(day - 1);
                r = c.deleteclass(batch_dep, roomno, coursename, classduration, sem, day1);
                return r;
            }
            else
            {
                return -2; // means that wrong day was selected
            }









        }

        public int Searchclass(Mclass obj)
        {
            TimeTable c = tlist.Find(t1).Value;
           int xx= c.Searchclass(obj);
            return xx;

        }

        // users part starts from here


        public int adduser(string username1, string password1, string email1, string name1)
        {
          
            User u1 = new User(username1, password1,email1,name1);

            int check = verifyuser(username1,password1);
            if (check== -1)
            {
                ulist.AddLast(u1);
                return 1;
            }
            else
            {
                return -1;
            }


              
            

            // User u1 = new User("junaid11", "123", "junaid@gmail.com", "junaid");
            //  User u2 = new User("awais11", "123", "awais@gmail.com", "awais");

            // ulist.AddLast(u1);
            // ulist.AddLast(u2);



        }

        public LinkedList<User> viewuser()
        {
            return ulist;
        }


        public int deleteuser(string s, string pass)
        {


                for (int i = 0; i < ulist.Count; i++)
                {
                    User y = ulist.ElementAt(i);

                    if (y.Username == s)
                    {
                        if (y.Password == pass)
                        {
                            ulist.Remove(ulist.ElementAt(i));
                            return 1;
                        }
                    }
                }

            return -1;
           
        }

       
      



        public int verifyuser(string username, string passward)
        {

           // adduser("s", "s", "s", "s");

           

            for (int i = 0; i < ulist.Count; i++)
            {
                User y = ulist.ElementAt(i);

                if (y.Username == username )
                {
                  if( y.Password == passward)
                    {
                        return 1;
                    }
                }
            }

           
                return -1;
            

        }

        public void writeuser()
        {
            Console.WriteLine("writing");

            // writing users
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = File.OpenWrite("user.bin"))
            {
                formatter.Serialize(stream, ulist);
            }
            write2();
            
            
        }

        public void readuser()
        {
            Console.WriteLine("reading");

            // reading users
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = File.OpenRead("user.bin"))
            {
               ulist=(LinkedList<User>)formatter.Deserialize(stream);
                
            }
            read2();

         

        }

        public void write2()
        {
            TimeTable c1 = tlist.ElementAt(0);
            c1.writeclass("c1.bin");

            TimeTable c2 = tlist.ElementAt(1);
            c2.writeclass("c2.bin");

            TimeTable c3 = tlist.ElementAt(2);
            c3.writeclass("c3.bin");

            TimeTable c4 = tlist.ElementAt(3);
            c4.writeclass("c4.bin");

            TimeTable c5 = tlist.ElementAt(4);
            c5.writeclass("c5.bin");

           
        }

        public void read2()
        {
            TimeTable c1 = tlist.ElementAt(0);
            c1.readclass("c1.bin");


            TimeTable c2 = tlist.ElementAt(1);
            c2.readclass("c2.bin");

            TimeTable c3 = tlist.ElementAt(2);
            c3.readclass("c3.bin");


            TimeTable c4 = tlist.ElementAt(3);
            c4.readclass("c4.bin");

            TimeTable c5 = tlist.ElementAt(4);
            c5.readclass("c5.bin");

        }




    }
}
