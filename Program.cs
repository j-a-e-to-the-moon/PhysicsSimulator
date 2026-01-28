using System.Numerics;
using PhysicsSimulator;
using static System.Numerics.Vector3;
using static PhysicsSimulator.World;

var world = new World(0);
world.Objects.Add(new BigObject(2, Zero, Zero));
BigObject object1 = world.Objects![0];

float dt = 1f;

for (int i = 0; i < 10; i++) // 우주가 생성되고 소멸되기까지 총 10 units의 시간을 가짐
{
    // apply force to object1
    var newForce = new Vector3(6, 6, 6);
    if (i < 5)
    {
        ApplyForce(object1, newForce);
    }

    foreach (var obj in world.Objects)
    {
        obj.Update(dt);
    }

    Console.WriteLine(object1);
}
