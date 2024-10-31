# Lớp Circle và Cylinder

## UML Diagram

      +-------------------+
      |      Circle       |
      +-------------------+
      | - radius: float   |
      | - color: string   |
      +-------------------+
      | + Circle()        |
      | + Circle(radius: float, color: string) |
      | + GetRadius(): float |
      | + SetRadius(radius: float): void |
      | + GetColor(): string |
      | + SetColor(color: string): void |
      | + GetArea(): float |
      | + ToString(): string |
      +-------------------+

             ^
             |
             |
      +-------------------+
      |     Cylinder     |
      +-------------------+
      | - height: float  |
      +-------------------+
      | + Cylinder()     |
      | + Cylinder(radius: float, color: string, height: float) |
      | + GetHeight(): float |
      | + SetHeight(height: float): void |
      | + GetVolume(): float |
      | + ToString(): string |
      +-------------------+
