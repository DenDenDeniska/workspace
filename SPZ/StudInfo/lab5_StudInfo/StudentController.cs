using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab5_StudInfo
{
    
    public class StudentController
    {
        
        public string NameOfList { get; private set; }
        public List<Student> StudentList { get ; set; }
        public BinaryFormatter format;

        
        public Student this[string _Name]
        {
            get
            {
                foreach(var element in StudentList)
                {
                    if (element.StudentName == _Name)
                        return element;
                }
                return null;
            }
        }

        public StudentController(string _NameOfList)
        {
            NameOfList = _NameOfList;
            StudentList = new List<Student>();
        }

        public void AddStudent(string _Name)
        {
            if(!_Name.Equals(""))
                StudentList.Add(new Student(_Name));
        }

        internal Student FindName(string _Name)
        {
            foreach (var element in StudentList)
            {
                if (element.StudentName == _Name)
                    return element;
            }
            return null;
        }

        public void DelStudent(string _Name)
        {
            if (!_Name.Equals(""))
                foreach (var element in StudentList)
                    if (element.StudentName == _Name)
                    {
                        StudentList.Remove(element);
                        return;
                    }
        }

        public void ToSerialize(string _nameOfFile)
        {
            format = new BinaryFormatter();
            using (FileStream file = new FileStream(_nameOfFile + ".bin", FileMode.Create))
            {
                format.Serialize(file, StudentList);
                file.Close();
            }
        }

        public void DeSerialize(string _nameOfFile)
        {
            format = new BinaryFormatter();
            using (FileStream file = new FileStream(_nameOfFile + ".bin", FileMode.Open))
            {
                StudentList = format.Deserialize(file) as List<Student> ;
               
            }

        }

        public override string ToString()
        {
            return NameOfList;
        }
    }
}
