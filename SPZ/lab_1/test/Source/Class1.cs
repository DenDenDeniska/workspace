using System;
using System.Collections.Generic;
using System.Text;
namespace test.Source
{
    enum Subjects {s_0,s_1,s_2,s_3,s_4,s_5,s_6,s_7,s_8,s_9};
    
    class Program
    {
        private static string str = "Hello, World !";
        static void Main(string[] args)
        {
            
                Dictionary<Subjects, short> marksmap = new Dictionary<Subjects, short>();

                marksmap.Add(Subjects.s_0, 10);
                marksmap.Add(Subjects.s_1, 20);
                marksmap.Add(Subjects.s_2, 30);
                marksmap.Add(Subjects.s_3, 40);
                marksmap.Add(Subjects.s_4, 50);
                marksmap.Add(Subjects.s_5, 60);
                marksmap.Add(Subjects.s_6, 70);
                marksmap.Add(Subjects.s_7, 80);
                marksmap.Add(Subjects.s_8, 90);
                marksmap.Add(Subjects.s_9, 100);
            
            ProfileStud Profile0 = new ProfileStud();
            Profile0.AddMarks(marksmap);


            ProfileStud Profile1 = new ProfileStud("www","10","3");
            Profile1.AddMarks(marksmap);
            Console.WriteLine("Profile1 Average : {0}", Profile1.CalcAverage());

            Console.WriteLine("Mark By Subject s_3: {0}", Profile1.GetMarkBySubject(Subjects.s_3));

            Profile1.SetMarkBySubject(Subjects.s_0, 100);
            Console.WriteLine("s_0 = 100");
            Console.WriteLine("Mark By Subject s_0: {0}", Profile1.GetMarkBySubject(Subjects.s_0));
            Console.WriteLine("Profile1 Average : {0}", Profile1.CalcAverage());

            Console.WriteLine(Profile1.ToString());

            Dictionary<Subjects, short> tMap = Profile1.Comparison(Profile0);


            ProfileStud Profile3 = new ProfileStud("", "10", "3");
            ProfileStud Profile4 = new ProfileStud("Admin", "", "4");
            ProfileStud Profile5 = new ProfileStud("www1111111", "16", "3");
            ProfileStud Profile6 = new ProfileStud("w111", "16", "");

            Console.ReadLine();
        }
    }

    class ProfileStud
    {   
        private string Name;
        private string ID;
        private string CourseYear;

        Dictionary<Subjects, short> Marks;

        public ProfileStud()
        {
            Console.WriteLine("*Have not data*");
        }
        public ProfileStud(string name, string id, string course)
        {
            
            short sError;
           
            if (id.Equals(""))
            {
                Console.WriteLine("*invalidate id*");
            }
            else
            {
                ID = id;
            }
           
            if (short.TryParse(name,out sError))
            {
                Console.WriteLine("*invalidate name* ");
            }
            else if(name.Equals(""))
            {
                Console.WriteLine("*Name is empty*");
            }
            else
            {
                Name = name;
            }

            if (course.Equals(""))
            {
                Console.WriteLine("*invalidate Cource*");
            }
            else
            {
                CourseYear = course; 
            }
           
        }
        
        public void AddMarks(Dictionary<Subjects, short> map)
        {
            Marks = new Dictionary<Subjects, short>(map);
        }
       
        public double CalcAverage()
        {
            double summ = 0;
            foreach (var element in this.Marks)
            {
                summ += element.Value;
            }
            return summ/10.0;
        }

        public short GetMarkBySubject(Subjects subject)
        {
            short Data;
            Marks.TryGetValue(subject,out Data);
            return Data;
        }
        public void SetMarkBySubject(Subjects subject, short mark)
        {
            foreach (var element in this.Marks)
            {
                if(element.Key == subject)
                {
                    Marks[element.Key] = mark;
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "Person: "+this.Name+"  ID: "+this.ID+"  Couse Year: "+this.CourseYear;
        }

        public Dictionary<Subjects, short> Comparison(ProfileStud stud)
        {
            Dictionary<Subjects, short> tValues = this.Marks;
            foreach(var element in stud.Marks)
            {
                tValues[element.Key] -= element.Value;
            }
            return tValues;
        }
    }
}
