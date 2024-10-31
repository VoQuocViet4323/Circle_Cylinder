public class Cylinder : Circle
{
    private float height = 1.0f;

    public Cylinder() : base() { }

    public Cylinder(float radius, string color, float height) : base(radius, color)
    {
        this.height = height;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float height)
    {
        this.height = height;
    }

    public float GetVolume()
    {
        return GetArea() * height;
    }

    public override string ToString()
    {
        return $"Cylinder[radius={GetRadius()}, color={GetColor()}, height={height}, volume={GetVolume()}]";
    }
}
