using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace program
{
    class operations
    {

        string path;
        string path2;
        public operations(string path ,string path2)
        {
            this.path = path;
            this.path2=path2;
        }
        public void createprofile(int id, string name, float cgpa, int semester, string dept, string uni)
        {
            
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(id);
                sw.WriteLine(name);
                sw.WriteLine(cgpa);
                sw.WriteLine(semester);
                sw.WriteLine(dept);
                sw.WriteLine(uni);



            }
        }


        public void SearchBySemeter(int semester)
        {

            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int ID = int.Parse(line);
                    string name = sr.ReadLine();
                    float cgpa = float.Parse(sr.ReadLine());
                    int sem = int.Parse(sr.ReadLine());
                    string dept = sr.ReadLine();
                    string uni = sr.ReadLine();

                    if (semester == sem)
                    {
                        Console.WriteLine("ID : " + ID);
                        Console.WriteLine("Name : " + name);
                        Console.WriteLine("CGPA : " + cgpa);
                        Console.WriteLine("Semester : " + sem);
                        Console.WriteLine("Department : " + dept);
                        Console.WriteLine("University  : " + uni);
                        count++;
                        break;
                    }

                }


                Console.WriteLine("Total record found" + ":" + count);

            }


        }

        public void searchname(string s_name)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int ID = int.Parse(line);
                    string name = sr.ReadLine();
                    float cgpa = float.Parse(sr.ReadLine());
                    int sem = int.Parse(sr.ReadLine());
                    string dept = sr.ReadLine();
                    string uni = sr.ReadLine();

                    if (s_name == name)
                    {
                        Console.WriteLine("ID : " + ID);
                        Console.WriteLine("Name : " + name);
                        Console.WriteLine("CGPA : " + cgpa);
                        Console.WriteLine("Semester : " + sem);
                        Console.WriteLine("Department : " + dept);
                        Console.WriteLine("University  : " + uni);
                        count++;
                        break;
                    }

                }

                Console.WriteLine("Total record found" + ":" + count);



            }


        }



        public void searchid(int s_id)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int ID = int.Parse(line);
                    string name = sr.ReadLine();
                    float cgpa = float.Parse(sr.ReadLine());
                    int sem = int.Parse(sr.ReadLine());
                    string dept = sr.ReadLine();
                    string uni = sr.ReadLine();

                    if (s_id == ID)
                    {
                        Console.WriteLine("ID : " + ID);
                        Console.WriteLine("Name : " + name);
                        Console.WriteLine("CGPA : " + cgpa);
                        Console.WriteLine("Semester : " + sem);
                        Console.WriteLine("Department : " + dept);
                        Console.WriteLine("University  : " + uni);
                        count++;
                        break;
                    }

                }


                Console.WriteLine("Total record found" + ":" + count);

            }
        }

        public void delete_profile(int s_id)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    int ID = int.Parse(line);
                    string name = sr.ReadLine();
                    float cgpa = float.Parse(sr.ReadLine());
                    int sem = int.Parse(sr.ReadLine());
                    string dept = sr.ReadLine();
                    string uni = sr.ReadLine();

                    if (s_id == ID)
                    {
                        File.Delete(name);

                        //line.Remove(name);
                        //line.Remove(cgpa;
                        //line.Remove(sem);
                        //line.Remove(dept);
                        //line.Remove(uni);

                    }

                }



            }



        }

        public void top_3()
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";

                float max = 0;
          
             

                line = sr.ReadLine();

                 
               

               

                while ((line = sr.ReadLine()) != null)
                {
                   
                string ID = line;
                string name = sr.ReadLine();
                float cgpa = float.Parse(sr.ReadLine());
                string sem = sr.ReadLine();
                string dept = sr.ReadLine();
                string uni = sr.ReadLine();
              

                    if (cgpa > max)
                    {
                    Console.WriteLine("ID : " + ID);
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("CGPA : " + cgpa);
                    Console.WriteLine("Semseter : " + sem);
                    Console.WriteLine("Department : " + dept);
                    Console.WriteLine("University  : " + uni);

                    }
             
                   
                }
             
                
        
            }
        }

        public void attendence(int semester)
        {

            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";

                while (((line = sr.ReadLine()) != null)&&line !="")
                {
                    
                    int ID = int.Parse(line);
                    string name = sr.ReadLine();
                    float cgpa = float.Parse(sr.ReadLine());
                    int sem = int.Parse(sr.ReadLine());
                    string dept = sr.ReadLine();
                    string uni = sr.ReadLine();

                    if (semester == sem)
                    {
                        string mark;
                        Console.WriteLine("ID : " + ID);
                        Console.WriteLine("Name : " + name);

                        mark = Console.ReadLine();
                         Console.WriteLine("you have marked " + name + ":" + mark);
                         using (StreamWriter sw = File.AppendText(path2))
                         {
                             sw.AutoFlush = true;
                             sw.WriteLine(ID.ToString());
                             sw.WriteLine(name);
                             sw.WriteLine(mark);


                          }
                    }    

               }

            }
         }



    public void view_attendence()
        {
            using (FileStream fs = File.Open(path2, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                string line = "";

                while (((line = sr.ReadLine()) != null))
                {
                
                    string ID =line;
                    string name = sr.ReadLine();
                     string mark = sr.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("ID : " + ID);
                        Console.WriteLine("Name : " + name);
                       Console.WriteLine("Today attendence : " + mark);
                        break;
                    }

                }

               
               

            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {


            string path = "C:/Users/asadk/Desktop/student.txt";
            string path2 = "C:/Users/asadk/Desktop/attendence.txt";
            if (args.Count()!=0)
            {
                path = args[0];
                path2 = args[1];
            }
            operations obj = new operations(path,path2);

            Console.WriteLine("Press 1 to create student profile");
            Console.WriteLine("Press 2 to search student");
            Console.WriteLine("Press 3 to delete student record");
            Console.WriteLine("Press 4 to list top 3 student");
            Console.WriteLine("Press 5 to mark attendence");
            Console.WriteLine("Press 6 to view attendence");
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();
            if (choice == 1)
            {
                int Id, Semester;
                string Name, deptt, Uni;
                float Cgpa;
                Console.WriteLine("enter id");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                Name = Console.ReadLine();
                Console.WriteLine("enter cgpa");
                Cgpa = float.Parse(Console.ReadLine());
                Console.WriteLine("enter semester");
                Semester = int.Parse(Console.ReadLine());
                Console.WriteLine("enter department");
                deptt = Console.ReadLine();
                Console.WriteLine("enter university");
                Uni = Console.ReadLine();
                
                obj.createprofile(Id, Name, Cgpa, Semester, deptt, Uni);


            }



            if (choice == 2)
            {


                Console.WriteLine("press 1 for name  search");
                Console.WriteLine("press 2  for id search");
                Console.WriteLine("press 3 for semester search");
                int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    String s_na;
                    Console.WriteLine("enter name for search");
                    s_na = Console.ReadLine();
                    obj.searchname(s_na);
                }
                if (choice2 == 2)
                {

                    int s_ids = 0;
                    Console.WriteLine("enter id for search");
                    s_ids = int.Parse(Console.ReadLine());
                    obj.searchid(s_ids);
                }
                if (choice2 == 3)
                {
                    int s_se = 0;
                    Console.WriteLine("enter semester for search");
                    s_se = int.Parse(Console.ReadLine());
                    obj.SearchBySemeter(s_se);
                }


            }
            if (choice==3)
            {
                Console.WriteLine("not available");
            }
            if (choice == 4)
            {
                Console.WriteLine("this is the data of topper");
                obj.top_3();
            }
            if (choice == 5)
            {
                int attsem;
                Console.WriteLine("enter semester for attendence");
               attsem = int.Parse(Console.ReadLine());

                obj.attendence(6);
            }
            if (choice == 6)
            {
                obj.view_attendence();
              }
          
        }
    }
}


    

