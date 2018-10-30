using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab3_CompManager
{
    class Task
    {
        private Stopwatch stopWatch;
        public DateTime DateStarting;
        public string Name { get; private set; }
        public bool isComplete { get; private set; }
        public bool isReady { get; private set; }
        public int TimeOfWorking { get; set; }
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
        }
        public Task(Task _T)
        {
            this.DateStarting = _T.DateStarting;
            this.isComplete = _T.isComplete;
            this.Name = _T.Name;
            this.stopWatch = _T.stopWatch;
        }
       
        public long GetTimeMil()
        {
            if (stopWatch != null)
                return stopWatch.ElapsedMilliseconds;
            else
                return 0;
            
        }
        public TimeSpan GetTime()
        {
            if (stopWatch != null)
                return stopWatch.Elapsed;
            else
                return new TimeSpan();

        }

        public async void StartTask(int _Delay)
        {
            isReady = false;
            stopWatch = new Stopwatch();

            await System.Threading.Tasks.Task.Run( () => 
            {
                stopWatch.Start();
                Thread.Sleep(_Delay);
                if (isReady == true)
                    return;
                stopWatch.Stop();
                isComplete = true;
            } );
            
            isReady = true;
        }
        public void StopTask()
        {
            isReady = true;
            stopWatch.Stop();
            isComplete = false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
