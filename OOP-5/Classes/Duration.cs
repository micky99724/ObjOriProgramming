using System.Text;

namespace OOP_5.Classes
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration() : this(0, 0, 0)
        {

        }
        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
            TimeConversion();
        }
        public Duration(int totalSeconds) : this(totalSeconds / 60 * 60, ((totalSeconds %= 3600) / 60), (totalSeconds %= 3600) % 60)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Hours != 0)
                sb.Append($"Hours: {Hours} , ");

            sb.Append($"Minutes :{Minutes}, Seconds :{Seconds}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Duration? duration = (Duration)obj;
            if (duration != null)
            {
                return Hours == duration?.Hours && Minutes == duration?.Minutes && Seconds == duration?.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.DurationToSeconds() + d2.DurationToSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return d + new Duration(seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return d + new Duration(seconds);
        }
        public static Duration operator ++(Duration d)
        {
            Duration duration = new Duration(d.Hours, d.Minutes + 60, d.Seconds);
            return duration;
        }
        public static Duration operator --(Duration d)
        {
            Duration duration = new Duration(d.Hours, d.Minutes - 60, d.Seconds);
            return duration;
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds=d1.DurationToSeconds() - d2.DurationToSeconds();
            return new Duration(totalSeconds);
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.DurationToSeconds() < d2.DurationToSeconds();
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.DurationToSeconds() > d2.DurationToSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.DurationToSeconds() >= d2.DurationToSeconds();
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.DurationToSeconds() <= d2.DurationToSeconds();
            
        }

        public static explicit operator DateTime(Duration v)
        {
            return new DateTime(2024, 08, 01, v.Hours, v.Minutes, v.Seconds);
        }
        private int DurationToSeconds()
        {
            return Seconds + Minutes * 60 + Hours * 3600;
        }
        public static implicit operator bool(Duration D)
        {
            return D.DurationToSeconds() > 0;
        }

        private void TimeConversion()
        {
            if (this.Seconds > 60)
            {
                this.Minutes += this.Seconds / 60;
                this.Seconds %= 60;
            }
            if (this.Minutes > 60)
            {
                this.Hours += this.Minutes / 60;
                this.Minutes %= 60;
            }
        }

    }
}
