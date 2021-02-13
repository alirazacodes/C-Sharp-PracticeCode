using System;

namespace StopWatch
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool _running = false;

        public void Start(DateTime start)
        {
            if (!_running)
            {
                StartTime = start;
                _running = true;
            }
            else
            {
                throw new InvalidOperationException("StopWatch is already running!");
            }
        }

        public void Stop(DateTime stop)
        {
            if (_running)
            {
                EndTime = stop;
                _running = false;
            }

        }

        public TimeSpan GetInterval()
        {
            var duration = EndTime - StartTime;

            return duration;
        }
    }
}