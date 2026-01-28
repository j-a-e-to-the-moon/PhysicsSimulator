using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulator;

internal record class BigObject(Single Mass, Vector3 Location, Vector3 Velocity)
{
    public Vector3 Location { get; set; } = Location;
    public Vector3 Velocity { get; set; } = Velocity;
    public Vector3 Acceleration { get; set; } = Vector3.Zero;
    public float Mass { get; } = Mass;

    public void Update(float dt)
    {
        Velocity += Acceleration * dt;
        Location += Velocity * dt;
        Acceleration = Vector3.Zero;
    }
}
