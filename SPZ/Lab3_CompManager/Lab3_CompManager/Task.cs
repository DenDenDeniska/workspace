using System;
using System.Threading;
using System.Diagnostics;

namespace Lab3_CompManager
{
    class Task
    {
        // класс для отслеживания времени работы 
        private Stopwatch stopWatch;

        // класс для отслеживания даты запуска задачи 
        public DateTime DateStarting;

        //Имя задачи
        public string Name { get; private set; }

        //Состояние выполнения
        public bool isComplete { get; private set; }

        //состояние готовности
        public bool isReady { get; private set; }

        //Максимальное время выполнения
        public int TimeOfWorking { get; set; }

        //Конструкторы
        public Task() 
        {
            Name = "Some task";
            DateStarting = new DateTime();
            stopWatch = new Stopwatch();
            isReady = false;
        }
        public Task(string _TaskName)
        {
            Name = _TaskName;
            DateStarting = new DateTime();
            stopWatch = new Stopwatch();
            isReady = false;
        }
        //Конструктор копирования
        public Task(Task _T)
        {
            this.DateStarting = new DateTime();
            this.DateStarting = _T.DateStarting;
            this.isComplete = _T.isComplete;
            this.Name = _T.Name;
            this.stopWatch = new Stopwatch();
        }
       
        //метод возвращения текущего времени выпонения в милисекундах
        public long GetTimeMil()
        {
            if (stopWatch != null)
                return stopWatch.ElapsedMilliseconds;
            else
                return 0;
            
        }

        //метод возвращения текущего времени выпонения в формате времени
        public TimeSpan GetTime()
        {
            if (stopWatch != null)
                return stopWatch.Elapsed;
            else
                return new TimeSpan();

        }

        //Запуск потока с задачей
        public async void StartTask(int _Delay)
        {
            isReady = false;
            stopWatch = new Stopwatch();

            await System.Threading.Tasks.Task.Run( () => 
            {
                stopWatch.Start();
                Thread.Sleep(_Delay);
                if (isReady == true)
                {
                    return;
                }
                stopWatch.Stop();
                isComplete = true;
            } );
            
            isReady = true;
        }

        //Фиксирование времени остановки задачи
        public void StopTask()
        {
            isReady = true;
            stopWatch.Stop();
            isComplete = false;
        }

        //Переопределение метода ToString
        public override string ToString()
        {
            return Name;
        }
    }
}
