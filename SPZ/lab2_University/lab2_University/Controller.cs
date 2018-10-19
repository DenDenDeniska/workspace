using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_University
{
    class Controller
    {
        
        public BindingList<University> Universities;

        public Controller()
        {
            Universities = new BindingList<University>();
        }
        public bool AddUniversity(string name)
        {
            foreach (var element in Universities)
            {
                if (element.IsFind(name))
                {
                    return false;
                }
            }
            Universities.Add(new University(name));
            return true;
           
        }
        public bool AddUniversity(University university)
        {
            foreach (var element in Universities)
            {
                if (element.NameOfUniversity == university.NameOfUniversity)
                {
                    return false;
                }
            }
            Universities.Add(university);
            return true;
            
        }
        public bool RemoveUniversity(string name)
        {
            foreach (var element in Universities)
            {
                if (element.IsFind(name))
                {
                    Universities.Remove(element);
                    return true;
                }
            }
            return false;
        }

        public University FindByName(string name)
        {
            foreach (var element in Universities)
            {
                if (element.IsFind(name))
                    return element;
            }
            return null;
        }

        
    }
}
