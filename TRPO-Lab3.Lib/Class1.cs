namespace TRPO_Lab3.Lib
{
    public class Class1
    {
        public static double CircleSegment(double radius, double angledegrees)
        {
            if (radius <= 0 || angledegrees <= 0)
            {
                throw new Exception("Радиус и угол должны быть заданы положительным числом");
            }
            double angleradians = angledegrees * Math.PI / 180;
            double area = (Math.Pow(radius, 2) / 2) * (angleradians - Math.Sin(angleradians));
            return area;
        }
    }
}