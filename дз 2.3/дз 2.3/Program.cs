using System;

class Shape
{
    public string Name { get; set; } // имя фигуры

    public Shape(string name)
    {
        Name = name;
    }
}

class Circle : Shape
{
    public double Radius { get; set; } // радиус круга

    public Circle(double radius) : base("круг")
    {
        Radius = radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; } // ширина прямоугольника
    public double Height { get; set; } // высота прямоугольника

    public Rectangle(double width, double height) : base("прямоугольник")
    {
        Width = width;
        Height = height;
    }
}

class Triangle : Shape
{
    public double Base { get; set; } // основание треугольника
    public double Height { get; set; } // высота треугольника

    public Triangle(double baseLength, double height) : base("треугольник")
    {
        Base = baseLength;
        Height = height;
    }
}

