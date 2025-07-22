using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Equality
        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
                return X == other.X && Y == other.Y && Z == other.Z;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        // Compare by X then Y
        public int CompareTo(Point3D other)
        {
            int result = X.CompareTo(other.X);
            if (result == 0)
                result = Y.CompareTo(other.Y);
            return result;
        }

        // Clone implementation
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
