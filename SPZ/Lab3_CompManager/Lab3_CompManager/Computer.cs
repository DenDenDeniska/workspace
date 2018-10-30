using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CompManager
{
    class Computer
    {
        //название
        public string Name_of_Computer { get; private set; }
        //список задач (с него можно вытаскивать и количество задач)
        public BindingList<Task> Tasks;

        public void AddTask(string _Name_of_task)
        {
            if (_Name_of_task.Equals(""))
            {
                Tasks.Add(new Task());
            }
            else
            {
                Tasks.Add(new Task(_Name_of_task));
            }
        }
        
        public Task FindTaskByName(string _task_name)
        {
            foreach (var element in Tasks)
            {
                if (_task_name == element.Name)
                {
                    return element;
                }
            }
            return null;
        }

        public Computer(string _Name)
        {
            Tasks = new BindingList<Task>();
            Name_of_Computer = _Name;
        }
        public Computer(Computer _C)
        {
            this.Tasks = _C.Tasks;
            this.Name_of_Computer = _C.Name_of_Computer;
        }
        //готовность к работе
        public bool isReady()
        {
            return true;
        }
        
        public static bool operator == (Computer comp_1,Computer comp_2)
        {
            foreach (var element1 in comp_1.Tasks)
            {
                foreach (var element2 in comp_2.Tasks)
                    if (element1 != element2)
                    {
                        return false;
                    }
            }
           return true;
        } 
        public static bool operator != (Computer comp_1,Computer comp_2)
        {
            foreach (var element1 in comp_1.Tasks)
            {
                foreach (var element2 in comp_2.Tasks)
                    if (element1 != element2)
                    {
                        return true;
                    }
            }
            return false;
        }

        public override string ToString()
        {
            return Name_of_Computer;
        }
    }
}
