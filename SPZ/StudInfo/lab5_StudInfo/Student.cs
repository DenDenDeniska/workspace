using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_StudInfo
{
    [Serializable]
    public struct PairLessonMark
    {
        public PairLessonMark(string _Lesson, int _Mark)
        {
            Lesson = _Lesson;
            Mark = _Mark;
        }
        public string Lesson { get; set; }
        public int Mark { get; set; }
        public override string ToString()
        {
            return Lesson + " " + Mark.ToString();
        }
    }

    [Serializable]
    public class Student
    {
        public string StudentName { get; set; }
        public List<PairLessonMark> Marks { get; set; }
        
        

        public Student(string _Name)
        {
            StudentName = _Name;
            Marks = new List<PairLessonMark>();
            Marks.Add(new PairLessonMark("some lesson", 0));
        }
        
        public void AddLesson(string _LName, int _Mark)
        {
            Marks.Add(new PairLessonMark(_LName, _Mark));   
        }
        

        
        public void Change(string _CurrentName,string _NewName, int _NewMark)
        {
            foreach (var element in Marks)
            {
                if(element.Lesson == _CurrentName)
                {
                    Marks.Remove(element);
                    Marks.Add(new PairLessonMark(_NewName, _NewMark));
                    return;
                }
            }
            
        }

       
    }
}
