using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormsLappolainen
{
    class Triangle
    {
        public double a; // Первая сторона
        public double b; // Вторая сторона
        public double c; // Третья сторона
        public double h; // Высота

        public Triangle(double A, double B, double C)//Конструктор 
        {
            a = A; // Создаём с заданами сторонами согласно заданию
            b = B;
            c = C;

        }
        public Triangle()
        {

        }
        public Triangle(double A,double H)
        {
            a = A;
            h = H;
        }
        public string OutputA() // вывод стороны A
        {
            return Convert.ToString(a);// ссылка на внутренее поле объекта класса
        }
        public string OutputB()// вывод стороны B
        {
            return Convert.ToString(b);
        }
        public string OutputC()// вывод стороны С
        {
            return Convert.ToString(c);
        }
        public string OutputH()// вывод Высоты
        {
            return Convert.ToString(h);
        }
        public double Perimeter()// cумма всех сторон типа Double
        {
            double p = 0;
            p = a + b + c;//вычисление
            return p;//возврат
        }
        public double Height()
        {
            double p = 0.5 * (a + b + c);
            double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;
            return h;
        }
        
        public double Hypotenuse()
        {
            double o;
            o = (a * a) +(b* b);
            c = Math.Sqrt(o);
            return o;
        }
        public double Surface() // аналочно с периметром также делаем и с площадью
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s= Math.Sqrt((p*(p-a) * (p-b) * (p-c)));
            return s;
        }
        public double GetSetA // позволяющая устоновить либо изменять значение сторон a
        {
            get//устанавливаем
            { return a; }
            set//меняем
            { a = value; }
        }
        public double GetSetB// позволяющая устоновить либо изменять значение сторон b
        {
            get//устанавливаем
            { return b; }
            set//меняем
            { b = value; }
        }
        public double GetSetC// позволяющая устоновить либо изменять значение сторон c
        {
            get//устанавливаем
            { return c; }
            set//меняем
            { c = value; }
        }
        public double GetSetH// позволяющая устоновить Высоту H
        {
            get//устанавливаем
            { return h; }
            set//меняем
            { h = value; }
        }
        public bool ExistTriangle//свойство позволяющее установить, существует ли треугольник с заданными свойствами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))// сумма двух сторон должна быть больше третьей
                    return true;
                else return false;
            }
        }
    }
   
}

