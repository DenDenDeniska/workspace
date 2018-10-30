using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_University
{
   
    
    class University 
    {
        public string[] Faculties { get; private set; }
        
        public string[] Labs { get; private set; }

        public string[] LectionRooms { get; private set; }

        /// <summary>
        /// реалізація індексатора за кількістю лабораторій та лекційних аудиторій
        /// </summary>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int type, uint index]
        {
            get
            {
                if (type == 0) return Faculties[index];
                else if (type == 1) return LectionRooms[index];
                else return Labs[index];
            }
            private set
            {
                if (type == 0) Faculties[index] = value;
                else if (type == 1) LectionRooms[index] = value;
                else Labs[index] = value;
            }
        }

        ///<summary>
        ///кількість факультетів
        ///</summary>
        public int NumberOfFaculties { get; private set; }

        /// <summary>
        /// кількість лабораторій
        /// </summary>
        public int NumberOfLabs { get; private set; }

        /// <summary>
        /// кількість студентів
        /// </summary>
        public int NumberOfStudents { get; private set; }

        /// <summary>
        /// кількість лекційних аудиторій
        /// </summary>
        public int NumberOfLectionRooms { get; private set; }

        /// <summary>
        /// назва
        /// </summary>
        public string NameOfUniversity { get; private set; }

        /// <summary>
        /// кількість викладачів(на 1 викладача максимум по 10 студентів)
        /// </summary>
        public int NumberOfTeachers { get; private set; }

        /// <summary>
        /// кількість осіб персоналу(на 1 співробітника по 2 аудиторії)
        /// </summary>
        public int NumberOfStaff { get; private set; }

        /// <summary>
        /// зачислення студентів
        /// </summary>
        public void EnrollmentStud()
        {
                ++NumberOfStudents;
        }

        /// <summary>
        /// відрахування студентів
        /// </summary>
        public void RemandStud()
        {
            if(NumberOfStudents > 0)
                --NumberOfStudents;
        }

        /// <summary>
        /// додавання ЛК аудиторій
        /// </summary>
        public void AddingLectionRooms(string name)
        {
            ++NumberOfLectionRooms;
            string[] temp = this.LectionRooms;
            this.LectionRooms = new string[NumberOfLectionRooms];
            for(var i = 0; i < NumberOfLectionRooms - 1; i++)
            {
                this.LectionRooms[i] = temp[i];
            }
            this.LectionRooms[LectionRooms.Length-1] = name;
        }

        /// <summary>
        ///  додавання ЛБ аудиторій
        /// </summary>
        public void AddingLabs(string name)
        {
            ++NumberOfLabs;
            string[] temp = this.Labs;
            this.Labs = new string[NumberOfLabs];
            for (var i = 0; i < NumberOfLabs - 1; i++)
            {
                this.Labs[i] = temp[i];
            }
            this.Labs[Labs.Length-1] = name;
        }

        /// <summary>
        /// конструктор ініціалізуючий
        /// </summary>
        public University(string name)
        {
            NameOfUniversity = name;
            Random rnd = new Random();
            Faculties = new string[100];
            for (var i = 0; i< Faculties.Length; i++ )
            {
                Faculties[i] = i.ToString();
            }
            Labs = new string[100];
            for (var i = 0; i < Labs.Length; i++)
            {
                Labs[i] = i.ToString();
            }
            NumberOfFaculties = Faculties.Length;
            NumberOfLabs = Labs.Length;
            NumberOfStudents = rnd.Next(500,5000);
            LectionRooms = new string[100];
            for (var i = 0; i < LectionRooms.Length; i++)
            {
                LectionRooms[i] = i.ToString();
            }
            NumberOfLectionRooms = LectionRooms.Length;
            NumberOfStaff = (NumberOfLectionRooms + NumberOfLabs) / 2;
            NumberOfTeachers = (NumberOfStudents / 10) + 1;

        }

        /// <summary>
        /// конструктор копіюючий
        /// </summary>
        public University(University temp)
        {
            this.Faculties = temp.Faculties;
            this.Labs = temp.Labs;
            this.LectionRooms = temp.LectionRooms;          
            this.NameOfUniversity = temp.NameOfUniversity;      
            this.NumberOfFaculties = temp.NumberOfFaculties;     
            this.NumberOfLabs = temp.NumberOfLabs;       
            this.NumberOfLectionRooms = temp.NumberOfLectionRooms;  
            this.NumberOfStaff = temp.NumberOfStaff;
            this.NumberOfStudents = temp.NumberOfStudents;
            this.NumberOfTeachers = temp.NumberOfTeachers;      
            
        }

        
        /// <summary>
        /// наймання співробітників(персонал/викладач)
        /// </summary>
        /// <param name="param">1 - преподаватель, 0 - персонал</param>
        public void EnrollmentStaff(ushort param)
        {
            switch (param)
            {
                case 0:
                        ++NumberOfStaff;
                    break;
                case 1:
                        ++NumberOfTeachers;
                    break;
            }
        }

        /// <summary>
        /// звільнення співробітників(персонал/викладач)
        /// </summary>
        /// <param name="param">1 - преподаватель, 0 - персонал</param>
        public void RemandStaff(ushort param)
        {
            switch (param)
            {
                case 0:
                    if(NumberOfStaff > 0)
                        --NumberOfStaff;
                    break;
                case 1:
                    if(NumberOfTeachers > 0)
                        --NumberOfTeachers;
                    break;
            }
        }

        /// <summary>
        /// оператор + (злиття 2 університетів)
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static University operator +(University u1, University u2)
        {
            University temp = new University("temp");

            temp.Labs = new string[u1.NumberOfLabs + u2.NumberOfLabs];
            int i;
            for (i = 0; i < u1.NumberOfLabs; i++)
            {
                temp.Labs[i] = u1.Labs[i];
            }
            for (var k = 0; k < u2.NumberOfLabs; k++,i++)
            {
                temp.Labs[i] = u2.Labs[k];
            }
            temp.NumberOfLabs = temp.Labs.Length;
            i = 0;
            temp.Faculties = new string[u1.NumberOfFaculties + u2.NumberOfFaculties];
            for (i=0; i < u1.NumberOfFaculties; i++)
            {
                temp.Faculties[i] = u1.Faculties[i];
            }
            for (var k=0; k < u2.NumberOfFaculties; k++,i++)
            {
                temp.Faculties[i] = u2.Faculties[k];
            }
            temp.NumberOfFaculties = temp.Faculties.Length;
            i = 0;
            temp.LectionRooms = new string[u1.NumberOfLectionRooms + u2.NumberOfLectionRooms];
            for (i = 0; i < u1.NumberOfLectionRooms; i++)
            {
                temp.LectionRooms[i] = u1.LectionRooms[i];
            }
            for (var k = 0; k < u2.NumberOfLectionRooms; k++,i++)
            {
                temp.LectionRooms[i] = u2.LectionRooms[k];
            }
            temp.NumberOfLectionRooms = temp.LectionRooms.Length;
            temp.NameOfUniversity = u1.NameOfUniversity + " and " + u2.NameOfUniversity;
            temp.NumberOfStaff = u1.NumberOfStaff + u2.NumberOfStaff;
            temp.NumberOfStudents = u1.NumberOfStudents + u2.NumberOfStudents;
            temp.NumberOfTeachers = u1.NumberOfTeachers + u2.NumberOfTeachers;
            return temp;

        }
        
        public bool IsFind(string name)
        {
            if (this.NameOfUniversity == name)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return NameOfUniversity;
        }
    }

    class UniversityEqualityComparer : IEqualityComparer<University>
    {
        public bool Equals(University u1,University u2)
        {
            if (u1.Faculties == u2.Faculties)
                return true;
            else
                return false;
        }
        public int GetHashCode(University university)
        {
            return university.Faculties.Length ^ university.Labs.Length;
        }
    }
}
