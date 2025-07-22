using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Duration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Normalize(hours * 3600 + minutes * 60 + seconds);
        }

        // Constructor: from total seconds
        public Duration(int totalSeconds)
        {
            Normalize(totalSeconds);
        }

        // Normalize to hours/minutes/seconds
        private void Normalize(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        // Convert to total seconds
        public int ToTotalSeconds() => Hours * 3600 + Minutes * 60 + Seconds;

        // ToString override
        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += $"Hours: {Hours}, ";
            if (Hours > 0 || Minutes > 0) result += $"Minutes :{Minutes}, ";
            result += $"Seconds :{Seconds}";
            return result;
        }

        // Equals override
        public override bool Equals(object obj)
        {
            if (obj is Duration d)
                return this.ToTotalSeconds() == d.ToTotalSeconds();
            return false;
        }

        public override int GetHashCode()
        {
            return ToTotalSeconds().GetHashCode();
        }

        // Operator + overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        // Operator - overloading
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Max(0, d1.ToTotalSeconds() - d2.ToTotalSeconds()));
        }

        // Operator ++ (increase 1 minute)
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }

        // Operator -- (decrease 1 minute)
        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(0, d.ToTotalSeconds() - 60));
        }

        // Comparison Operators
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            if (d1 is null && d2 is null) return true;
            if (d1 is null || d2 is null) return false;
            return d1.Equals(d2);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        // true / false operator overloading
        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() == 0;
        }

        // Explicit cast to DateTime (Duration from midnight)
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}
