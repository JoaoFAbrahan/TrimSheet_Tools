using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimSheet_Tools.Model
{
    public class Vector2D
    {
        // Global variables
        public float X { get; set; }
        public float Y { get; set; }


        // Constructor
        public Vector2D(float x, float y)
        { X = x; Y = y; }
        public Vector2D() : this(0, 0) { }


        // Methods
        public float Magnitude()
        { return (float)Math.Sqrt(X * X + Y * Y); }

        public Vector2D Normalize()
        {
            float mag = Magnitude();
            if (mag > 0)
                return new Vector2D(X / mag, Y / mag);

            return new Vector2D();
        }

        public override string ToString()
        { return $"{X}x{Y}"; }

        // Operators
        public static Vector2D operator +(Vector2D a, Vector2D b)
        { return new Vector2D(a.X + b.X, a.Y + b.Y); }
        public static Vector2D operator -(Vector2D a, Vector2D b)
        { return new Vector2D(a.X - b.X, a.Y - b.Y); }

        public static Vector2D operator *(Vector2D vector, float scalar)
        { return new Vector2D(vector.X * scalar, vector.Y * scalar); }
        public static Vector2D operator *(float scalar, Vector2D vector)
        { return vector * scalar; }

        public static Vector2D operator /(Vector2D vector, float scalar)
        {
            if (Math.Abs(scalar) < float.Epsilon)
                throw new DivideByZeroException("You cannot divide a vector by zero.");

            return new Vector2D(vector.X / scalar, vector.Y / scalar);
        }
    }
}
