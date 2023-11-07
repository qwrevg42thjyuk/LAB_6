using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class Class4
    {
    }
}
using System;
using System.Collections.Generic;

abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}

class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public override void Draw()
    {
        // Логіка малювання кола
    }
}

class Rectangle : GraphicPrimitive
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw()
    {
        // Логіка малювання прямокутника
    }
}

class Triangle : GraphicPrimitive
{
    public override void Draw()
    {
        // Логіка малювання трикутника
    }
}

class Group : GraphicPrimitive
{
    public List<GraphicPrimitive> Primitives { get; set; }

    public override void Draw()
    {
        foreach (var primitive in Primitives)
        {
            primitive.Draw();
        }
    }

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        Primitives.Add(primitive);
    }

    public void Scale(float factor)
    {
        // Логіка масштабування всіх примітивів у групі
    }
}

class GraphicsEditor
{
    public List<GraphicPrimitive> Primitives { get; set; }

    public GraphicsEditor()
    {
        Primitives = new List<GraphicPrimitive>();
    }

    public void DrawAll()
    {
        foreach (var primitive in Primitives)
        {
            primitive.Draw();
        }
    }

    public void ScaleAll(float factor)
    {
        foreach (var primitive in Primitives)
        {
            if (primitive is Group group)
            {
                group.Scale(factor);
            }
        }
    }
}
