using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2._0.backend
{
    [Serializable]
    internal class TimeTable
    {

        private string totalduration;
        private int Day;
        //ArrayList completeday=new ArrayList();



        // storing my classes in implemented linked list
        LinkedList<Mclass> classlist = new LinkedList<Mclass>();
        private int listsize = 9;




        public TimeTable(string totalduration, int day)
        {
            this.Totalduration = totalduration;
            Day = day;


            for(int i=0; i<9; i++)
            {
                // making 9 classes emptpy already so that later on we will just replace it
                Mclass mm = new Mclass("empty","empty", "empty", "empty", "empty");


                classlist.AddLast(mm);
            }

           
        }


        public string Totalduration { get => totalduration; set => totalduration = value; }
        public int Day1 { get => Day; set => Day = value; }
        public int Listsize { get => listsize; set => listsize = value; }



        public int addclass1(string batch_dep, string roomno, string coursename, string classduration, string sem, string day1)
        {
            

            int slot = Int16.Parse(classduration);
            if (slot > 0 && slot < 10)
            {
                Mclass cc = classlist.ElementAt(slot-1);
                if (cc.Batch_dep== "empty")
                {
                   
                    Mclass mclassobj = new Mclass(batch_dep, roomno, coursename, classduration, sem);

                    classlist.Find(cc).Value = mclassobj;
                    return 1;
                }
                else
                {
                    return -1; // slot is already filled
                }

            }
            else
            {
                return -3; // wrong slot selected
            }

        }

        public LinkedList<Mclass> viewclass()
        {
            return classlist;
        }


        public int deleteclass(string batch_dep, string roomno, string coursename, string classduration, string sem, string day1)
        {
            //you will provide it the object or class object to delete it 
            

           


            int slot = Int16.Parse(classduration);
            if (slot > 0 && slot < 10)
            {
                Mclass cc = classlist.ElementAt(slot - 1);
                if (cc.Batch_dep == "empty")
                {

                    // slot is already empty
                    return -1;
                }
                else
                {
                    Mclass mclassobj = new Mclass(batch_dep, roomno, coursename, classduration, sem);

                   
                    classlist.Remove(mclassobj);
                    Mclass mm = new Mclass("empty", "empty", "empty", "empty", "empty");
                    classlist.Find(cc).Value = mm;
                    return 1; 
                }

            }
            else
            {
                return -3; // wrong slot selected
            }




        }

        public int Searchclass(Mclass obj)
        {
            LinkedListNode<Mclass> result = classlist.Find(obj);

            if (result != null)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }


        public void writeclass(String file)
        {
            Console.WriteLine("writing");


            BinaryFormatter formatter = new BinaryFormatter();
            // time talbe
            using (Stream stream = File.OpenWrite(file))
            {
                formatter.Serialize(stream, classlist);
            }


        }

        public void readclass(string file)
        {
            Console.WriteLine("reading");



            BinaryFormatter formatter = new BinaryFormatter();

            // reading time table
            using (Stream stream = File.OpenRead(file))
            {
                classlist = (LinkedList<Mclass>)formatter.Deserialize(stream);

            }


        }






















    }
}
