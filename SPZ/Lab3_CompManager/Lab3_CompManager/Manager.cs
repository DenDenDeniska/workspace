using System.Collections.Generic;
using System.ComponentModel;

namespace Lab3_CompManager
{
    class Manager
    {
        //контейнер для хранения компьютеров
        public BindingList<Computer> Computers;

        //Отображение для возможных задач 
        public Dictionary<int, Task> DictionaryOfTasks;

        //пароль для изменения состояния сети
        private string Pass = "admin";

        //Количество количество рабочих компьютеров
        public int NumberOfWorkspace { get; private set; }

        //Состояние WLAN
        public bool Wifi { get; private set; }

        //конструктор класса Manger
        public Manager()
        {
            Computers = new BindingList<Computer>();
            DictionaryOfTasks = new Dictionary<int, Task>();
        }

        //метод поиска компьютера по имени
        internal Computer FindComputerByName(string _Name)
        {
            foreach(var element in Computers)
            {
                if (_Name == element.Name_of_Computer)
                    return element;
            }
            return null;
        }

        //метод поиска существующей задачи по имени
        internal Task FindTaskByName(string _Name)
        {
            foreach (var element in DictionaryOfTasks)
            {
                if (_Name == element.Value.Name)
                    return element.Value;
            }
            return null;
        }
        
        //метод переключения состояния сети
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

        //метод переключения состояния сети
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
        
        //добавление задачи к нужному компьютеру
        public void AddTask(string _Name_of_Computer,string _Name_of_Task)
        {
            FindComputerByName(_Name_of_Computer).Tasks.Add(new Task(FindTaskByName(_Name_of_Task)));
        }
    }
}
