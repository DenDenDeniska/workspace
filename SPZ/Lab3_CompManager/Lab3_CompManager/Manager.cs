using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CompManager
{
    class Manager
    {
        public BindingList<Computer> Computers;
        public Dictionary<int, Task> DictionaryOfTasks;
        private Computer FindComputerByName(string _Name)
        {
            foreach(var element in Computers)
            {
                if (_Name == element.Name_of_Computer)
                    return element;
            }
            return null;
        }
        internal Task FindTaskByName(string _Name)
        {
            foreach (var element in DictionaryOfTasks)
            {
                if (_Name == element.Value.Name)
                    return element.Value;
            }
            return null;
        }
        public Manager()
        {
            Computers = new BindingList<Computer>();
            DictionaryOfTasks = new Dictionary<int, Task>();
        }
        public int NumberOfWorkspace { get; private set; }
        public Computer FindComputer(string _Name)
        {
            foreach (var element in Computers)
            {
                if(_Name == element.Name_of_Computer)
                {
                    return element;
                }
            }
            return null;
        } 
        public bool Wifi { get; private set; }
        public bool EnableWiFi(string _pass)
        {
            if(_pass != this.Pass)
            {
                return false;
            }
            else
            {
                Wifi = true;
                return true;
            }
        }
        public bool DisableWiFi(string _pass)
        {
            if (_pass != this.Pass)
            {
                return false;
            }
            else
            {
                Wifi = false;
                return true;
            }
        }
        private string Pass = "admin";
        public void AddTask(string _Name_of_Computer,Task _NewTask)
        {
            foreach (var element in Computers)
            {
                if (_Name_of_Computer == element.Name_of_Computer)
                {
                    element.Tasks.Add(_NewTask);
                }
            }
        }
        public void AddTask(string _Name_of_Computer,string _Name_of_Task)
        {
            FindComputerByName(_Name_of_Computer).Tasks.Add(FindTaskByName(_Name_of_Task));
        }
        
        
    }
}
