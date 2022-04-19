using System;
namespace ImplementingInterfaceApp
{
interface IRectangle
{
void Area(int width, int height);
}
interface ITriangle
{
void Area(int width, int height);
}
class Shape : IRectangle, ITriangle
{
void IRectangle.Area(int width, int height)
{
Console.WriteLine("Rectangle Area : " + width * height);
}
void ITriangle.Area(int width, int height)
{
Console.WriteLine("Triangle Area : " + width * height / 2);
}
}
