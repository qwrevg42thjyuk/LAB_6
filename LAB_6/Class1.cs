using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class Class1
    {
    }
}
using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public double Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

class Human
{
    public double Speed { get; set; }

    public void Move()
    {
        // Логіка руху людини
    }
}

class Car : Vehicle
{
    public Car()
    {
        Speed = 100;
        Capacity = 5;
    }

    public override void Move()
    {
        // Логіка руху автомобіля
    }
}

class Bus : Vehicle
{
    public Bus()
    {
        Speed = 60;
        Capacity = 40;
    }

    public override void Move()
    {
        // Логіка руху автобуса
    }
}

class Train : Vehicle
{
    public Train()
    {
        Speed = 120;
        Capacity = 200;
    }

    public override void Move()
    {
        // Логіка руху поїзда
    }
}

class TransportNetwork
{
    public List<Vehicle> Vehicles { get; set; }

    public TransportNetwork()
    {
        Vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in Vehicles)
        {
            vehicle.Move();
        }
    }
}
