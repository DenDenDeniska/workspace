using System;
using System.Collections.Generic;

namespace test.Source
{
    enum Subjects {s_0,s_1,s_2,s_3,s_4,s_5,s_6,s_7,s_8,s_9};
    //основной класс программы
    class Program
    {
        private static string str = "Hello, World !";//традиция, данная строчка не обсуждается
        static void Main(string[] args)
        { 
            Controller controller = new Controller();

            controller.AddProfile("", "", "");
            controller.AddProfile("Test_number111", "IDTest1", "3");
            controller.AddProfile("Profile_test", "ID Test_with_tab", "3");
            controller.AddProfile("Profile_test", "IDTest3", "-3");
            //////////////////////////////////////////////////////////////
            controller.AddProfile("Profile", "ID001", "3");
            controller.FindProfile("Profile", "ID001", "3").AddMarks(RewriteMarks());
            //////////////////////////////////////////////////////////////
            controller.AddProfile("Profile", "ID002", "3");
            controller.FindProfile("Profile", "ID002", "3").AddMarks(RewriteMarks());
            //////////////////////////////////////////////////////////////
            controller.AddProfile("Profile", "ID003", "3");
            controller.FindProfile("Profile", "ID003", "3").AddMarks(RewriteMarks());
            Console.WriteLine("{0} : Subject s_8 - {1}",
                controller.FindProfile("Profile", "ID003", "3").ToString(), 
                controller.FindProfile("Profile", "ID003", "3").GetMarkBySubject(Subjects.s_8));
            controller.FindProfile("Profile", "ID003", "3").SetMarkBySubject(Subjects.s_8, 100);
            Console.WriteLine("{0} : Subject s_8 - {1}",
                controller.FindProfile("Profile", "ID003", "3").ToString(),
                controller.FindProfile("Profile", "ID003", "3").GetMarkBySubject(Subjects.s_8));
            ///////////////////////////////////////////////////////////////
            Dictionary<Subjects, short> tMap = 
                controller.FindProfile("Profile", "ID001", "3").Comparison(controller.FindProfile("Profile", "ID002", "3"));
            ///////////////////////////////////////////////////////////////
            controller.AddProfile("Profile", "ID004", "4");
            controller.FindProfile("Profile", "ID004", "4").AddMarks(RewriteMarks());
            Console.WriteLine("Average score by {1} - {0}",
                controller.FindProfile("Profile", "ID004", "4").CalcAverage(),
                controller.FindProfile("Profile", "ID004", "4").ToString());
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Result of comparison :");
            foreach (var element in tMap)
            {
                Console.WriteLine("{0} = {1}",element.Key.ToString(),element.Value);
            }
            ///////////////////////////////////////////////////////////////
            Console.ReadLine();
        }

        //тестовый метод генерации оценок 
        public static Dictionary<Subjects, short> RewriteMarks()
        {
            Dictionary<Subjects, short> marksmap = new Dictionary<Subjects, short>();
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            marksmap.Add(Subjects.s_0, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_1, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_2, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_3, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_4, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_5, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_6, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_7, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_8, (short)rnd.Next(0, 100));
            marksmap.Add(Subjects.s_9, (short)rnd.Next(0, 100));
            return marksmap;
        }
    }

    //для удобства обработки входных данных в основной класс с информацией можна использовать внешний класс контроллер
    class Controller
    {
        //вектор для хранения профилей студентов
        public List<ProfileStud> ListOfStudents;

        //использован конструктор по умолчанию, так как для инициализации контейнера с профилями не требуются данные
        public Controller()
        {
            ListOfStudents = new List<ProfileStud>();
        }

        //метод для обработки ошибок и добавления в контейнер профилей только корректных данных
        public void AddProfile(string name,string id, string course)
        {

            if (name.Equals(""))
            {
                Console.WriteLine("Name is empty");
                return;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                {
                    Console.WriteLine("Invalidate name. You must write without numbers");
                    return;
                }
            }
            if (id.Equals(""))
            {
                Console.WriteLine("ID is empty");
                return;
            }
            if (id.Contains(" "))
            {
                Console.WriteLine("Invalidate ID. You must wrire without tabs");
                return;
            }
            if (course.Equals(""))
            {
               Console.WriteLine("Cource is empty");
                return;
            }
            if (short.Parse(course) <= 0) 
            {
                Console.WriteLine("Invalidate course. You must write number more then null");
                return;
            }
            ListOfStudents.Add(new ProfileStud(name, id, course));
        }

        //метод для возвращения из текущего объекта нужный профиль(используем для дальнейшего поиска и редактирования нужного контейнера)
        public ProfileStud FindProfile(string name, string id, string course)
        {
            for (var i = 0; i < this.ListOfStudents.Count;i++)
            {
                if (this.ListOfStudents[i].IsFind(name, id, course))
                {
                    return this.ListOfStudents[i];
                }
            }
            return null;
        }
    }

    //класс профиля студента
    class ProfileStud
    {   
        private string Name;
        private string ID;
        private string CourseYear;

        //отображение, где предмет - ключ, оценка за него - значение (позволит сделать предметы уникальными и добавит удобства работы с оценками)
        Dictionary<Subjects, short> Marks;

        //инициализирующий конструктор
        public ProfileStud(string name, string id, string course)
        {
                ID = id;
                Name = name;
                CourseYear = course; 
        }
        
        //метод, доббавляющий привязывающий отображение с оценками к студенту 
        public void AddMarks(Dictionary<Subjects, short> map)
        {
            Marks = new Dictionary<Subjects, short>(map);
        }
       
        //метод вычесления среднего балла
        public double CalcAverage()
        {
            double summ = 0;
            foreach (var element in this.Marks)
            {
                summ += element.Value;
            }
            return summ/(double)Marks.Count;
        }

        //метод возврата оценки по соответствующему предмету
        public short GetMarkBySubject(Subjects subject)
        {
            short Data;
            Marks.TryGetValue(subject,out Data);
            return Data;
        }

        //метод записи оценки для заданного предмета
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

        //перегрузка метода ToString
        public override string ToString()
        {
            return "Person: "+this.Name+"  ID: "+this.ID+"  Couse Year: "+this.CourseYear;
        }

        //метод возврата результата сравнения оценок текущего профиля с выбранным
        public Dictionary<Subjects, short> Comparison(ProfileStud stud)
        {
            Dictionary<Subjects, short> tValues = this.Marks;
            foreach(var element in stud.Marks)
            {
                tValues[element.Key] -= element.Value;
            }
            return tValues;
        }

        //метод для потверждения найденого профиля при поиске по имени, идентификатору и курсу  
        public bool IsFind(string name, string id, string course)
        {
            if (Name == name && ID == id && CourseYear == course)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
