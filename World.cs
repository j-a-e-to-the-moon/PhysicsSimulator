using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulator;

internal class World(int time)
{
    public int Time { get; } = time;
    public List<BigObject> Objects { get; set; } = [];

    // F= ma
    public static Vector3 CalculateAcceleration(Vector3 force, BigObject obj) => force / obj.Mass;

    public static void ApplyForce(BigObject obj, Vector3 force)
    {
        obj.Acceleration += CalculateAcceleration(force, obj);
        Console.WriteLine($"The acceleration is {obj.Acceleration}!");
    }
}
