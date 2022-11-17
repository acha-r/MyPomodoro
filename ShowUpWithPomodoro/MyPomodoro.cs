using System;
using System.Diagnostics;
using System.Timers;
using System.Threading;

namespace ShowUpWithPomodoro
{
    internal class MyPomodoro
    {
        private static DateTime startTime = DateTime.Now;
        private static Stopwatch onePomodoro;
        private static Stopwatch breakTime;
        private static int intendedNumOfPomodoros;
        private static int pomodoroCompleted = 0;
       

        public static int PomodoroCount(int pomCount = 2)
        {
            
            for (int i = 1; i <= pomCount; i++)
            {
               
                intendedNumOfPomodoros = pomCount;
                onePomodoro = new Stopwatch();
                onePomodoro.Start();
                Thread.Sleep(10000); //30 seconds
                onePomodoro.Stop();
                pomodoroCompleted++;
                if (i < pomCount)
                {
                    Console.WriteLine($"You have completed {pomodoroCompleted} pomodoro\n");
                    Console.WriteLine("Take a break\n");
                    BreakTime();
                }
                else if (i == pomCount) Console.WriteLine("Well done. You have reached your goal");
                TimeSpan ts = onePomodoro.Elapsed;
                string timeElapsed = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                Console.WriteLine($"\nYou completed {pomodoroCompleted} pomodoro in {timeElapsed}");
               
                
            }
            
            return pomodoroCompleted;
        }

        public static void BreakTime()
        {
            breakTime = new Stopwatch();
            breakTime.Start();
            Thread.Sleep(10000);
            breakTime.Stop();
            Console.WriteLine("Break Over. Get to work!");
        }


    }

}
