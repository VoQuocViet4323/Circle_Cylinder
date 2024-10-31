using System;

public class Circle
{
    private float radius = 1.0f;
    private string color = "red";

    public Circle() { }

    public Circle(float radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public float GetRadius()
    {
        return radius;
    }

    public void SetRadius(float radius)
    {
        this.radius = radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public float GetArea()
    {
        return (float)(Math.PI * radius * radius);
    }

    public override string ToString()
    {
        return $"Circle[radius={radius}, color={color}, area={GetArea()}]";
    }
}
