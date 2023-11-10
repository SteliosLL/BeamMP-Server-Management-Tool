using System;
using System.Threading;
using System.Threading.Tasks;

namespace BeamMP_Tool
{
    public class CountDownTimer
    {
        public Action TimeChanged;
        public Action CountDownFinished;
        public TimeSpan tLeft => timeLeft;
        bool stop = false;
        public bool isRunning = false;
        public void Start(int seconds)
        {
            stop = false;
            doCountdown(seconds);
            isRunning = true;
        }
        public void Stop()
        {
            stop = true;
        }
        TimeSpan timeLeft = TimeSpan.Zero;
        private void doCountdown(int seconds)
        {
            Task t = Task.Run(() =>
            {
                TimeSpan endT = DateTime.Now.TimeOfDay + TimeSpan.FromSeconds(seconds);
                while (!stop)
                {
                    timeLeft = endT - DateTime.Now.TimeOfDay;
                    TimeChanged?.Invoke();
                    if (timeLeft.TotalSeconds <= 0)
                    {
                        CountDownFinished?.Invoke();
                        isRunning = false;
                        stop = true;
                        break;
                    }
                    Thread.Sleep(100);
                }
                isRunning = false;
            });
        }
    }
}
