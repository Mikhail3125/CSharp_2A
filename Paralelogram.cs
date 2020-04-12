using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab_2A
{
    public class Paralelogram
    {

        //Конструктор
        public Paralelogram(double bottom, double side, double lowerLeftAngle)
        {
            Bottom = bottom;
            Side = side;
            LowerLeftAngle = lowerLeftAngle;
        }

        //Основание (нижняя горизонтальная сторона)
        public double Bottom
        {
            get;
            protected set;
        }

        //Другая сторона, смежная с основанием
        public double Side
        {
            get;
            protected set;
        }

        //Левый нижний угол
        public double LowerLeftAngle
        {
            get;
            protected set;
        }

        //Высота
        public double Height
        {
            get
            {
                return Side * Math.Sin(LowerLeftAngle);
            }
        }

        //Периметр
        public double Perimeter
        {
            get
            {
                return 2 * (Side + Bottom);
            }
        }

        //Площадь
        public double Area
        {
            get
            {
                return Bottom * Height;
            }
        }

        //Длина (наибольшая из сторон)
        public double Length
        {
            get
            {
                return Math.Max(Bottom, Side);
            }
        }

        //Ширина (наименьшая из сторон)
        public double Width
        {
            get
            {
                return Math.Min(Bottom, Side);
            }
        }

    }
}
