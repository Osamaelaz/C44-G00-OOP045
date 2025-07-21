using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int h, int m, int s)
        {
            Normalize(h * 3600 + m * 60 + s);
        }

        public Duration(int totalSeconds)
        {
            Normalize(totalSeconds);
        }

        private void Normalize(int total)
        {
            Hours = total / 3600;
            Minutes = (total % 3600) / 60;
            Seconds = total % 60;
        }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            return $"Seconds: {Seconds}";
        }

        public static Duration operator +(Duration a, Duration b) => new Duration(a.ToSeconds() + b.ToSeconds());
        public static Duration operator +(Duration a, int seconds) => new Duration(a.ToSeconds() + seconds);
        public static Duration operator +(int seconds, Duration a) => new Duration(a.ToSeconds() + seconds);
        public static Duration operator -(Duration a, Duration b) => new Duration(a.ToSeconds() - b.ToSeconds());

        public static Duration operator ++(Duration d) => new Duration(d.ToSeconds() + 60);
        public static Duration operator --(Duration d) => new Duration(d.ToSeconds() - 60);
      
        public static bool operator >(Duration a, Duration b) => a.ToSeconds() > b.ToSeconds();
        public static bool operator <(Duration a, Duration b) => a.ToSeconds() < b.ToSeconds();
        public static bool operator >=(Duration a, Duration b) => a.ToSeconds() >= b.ToSeconds();
        public static bool operator <=(Duration a, Duration b) => a.ToSeconds() <= b.ToSeconds();
     
        public static explicit operator DateTime(Duration d) => DateTime.Today.AddSeconds(d.ToSeconds());

        private int ToSeconds() => Hours * 3600 + Minutes * 60 + Seconds;
    }

}
