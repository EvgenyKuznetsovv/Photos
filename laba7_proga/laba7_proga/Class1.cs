using System;
using System.Collections.Generic;
using System.Text;

namespace laba7_proga
{
    public class Complex
    {
        private double valid;// действительная
        private double imaginary;// мнимая 
        public Complex()
        {
            valid = 0;
            imaginary = 0;
        }
        public Complex(double valid, double imaginary)
        {
            this.valid = valid;
            this.imaginary = imaginary;
        }
        public Complex(Complex item)
        {
            valid = item.valid;
            imaginary = item.imaginary;

        }
        public double GetValid()
        {
            return valid;
        }
        public double GetImaginary()
        {
            return imaginary;
        }
        public void SetValid(double val)
        {
            valid = val;
        }
        public void SetImaginary(double imag)
        {
            imaginary = imag;
        }
        public double modul()
        {
            return Math.Sqrt(Math.Pow(valid, 2) + Math.Pow(imaginary, 2));
        }

        public static Complex operator +(Complex one, Complex two)
        {
            Complex temp = new Complex();
            temp.valid = one.valid + two.valid;
            temp.imaginary = two.imaginary + one.imaginary;
            return temp;
        }

        public static Complex operator +(Complex com, double dob)
        {
            Complex temp = new Complex();
            temp.valid = com.valid + dob;
            temp.imaginary = com.imaginary;
            return temp;
        }

        public static Complex operator +(double dob, Complex com)
        {
            Complex temp = new Complex();
            temp.valid = com.valid + dob;
            temp.imaginary = com.imaginary;
            return temp;
        }

        public static Complex operator -(Complex one, Complex two)
        {
            Complex temp = new Complex();
            temp.valid = one.valid - two.valid;
            temp.imaginary = one.imaginary - two.imaginary;
            return temp;
        }

        public static Complex operator -(Complex com, double dob)
        {
            Complex temp = new Complex();
            temp.valid = com.valid - dob;
            temp.imaginary = com.imaginary;
            return temp;
        }

        public static Complex operator -(double dob, Complex com)
        {
            Complex temp = new Complex();
            temp.valid = dob - com.valid;
            temp.imaginary = 0 - com.imaginary;
            return temp;
        }

        public static Complex operator *(Complex one, Complex two)
        {
            Complex temp = new Complex();
            temp.valid = one.valid * two.valid - one.imaginary * two.imaginary;
            temp.imaginary = one.valid * two.imaginary + two.valid * one.imaginary;
            return temp;
        }

        public static Complex operator *(Complex one, double dob)
        {
            Complex temp = new Complex();
            Complex two = new Complex(dob, 0);
            temp.valid = one.valid * two.valid - one.imaginary * two.imaginary;
            temp.imaginary = one.valid * two.imaginary + two.valid * one.imaginary;
            return temp;
        }

        public static Complex operator *(double dob, Complex two)
        {
            Complex temp = new Complex();
            Complex one = new Complex(dob, 0);
            temp.valid = one.valid * two.valid - one.imaginary * two.imaginary;
            temp.imaginary = one.valid * two.imaginary + two.valid * one.imaginary;
            return temp;
        }

        public static Complex operator /(Complex one, Complex two)
        {
            Complex temp = new Complex();
            if (Math.Pow(two.valid, 2) + Math.Pow(two.imaginary, 2) == 0)
            {
                return temp; // если нельзя разделить то зануляет элемент
            }
            temp.valid = (one.valid * two.valid + one.imaginary * two.imaginary) / (Math.Pow(two.valid, 2) + Math.Pow(two.imaginary, 2));
            temp.imaginary = (two.valid * one.imaginary - one.valid * two.imaginary) / (Math.Pow(two.valid, 2) + Math.Pow(two.imaginary, 2));

            return temp;
        }

        public static Complex operator /(double dob, Complex two)
        {
            Complex temp = new Complex();
            Complex one = new Complex(dob, 0);
            return one / two;
        }

        public static Complex operator /(Complex one, double dob)
        {
            Complex temp = new Complex();
            Complex two = new Complex(dob, 0);
            return one / two;
        }

        public static bool operator false(Complex one) => one.valid == 0 && one.imaginary == 0;
        public static bool operator true(Complex one) => one.valid != 0 || one.imaginary != 0;
        public new string ToString()
        {
            String text = "";
            text += valid.ToString();
            text += "+";
            text += imaginary.ToString();
            text += "i";
            return text;
        }

        public static Complex operator ++(Complex a)
        {
            a.valid++;
            return a;
        }

        public static Complex operator --(Complex a)
        {
            a.valid--;
            return a;
        }

        public static explicit operator double(Complex num)
        {
            return num.valid;
        }

        public static implicit operator Complex(double num)
        {
            Complex temp = new Complex(num, 0);
            return temp;
        }

        public static bool operator ==(Complex one, Complex two)
        {
            if ((one.valid == two.valid) && (one.imaginary == two.imaginary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Complex one, Complex two)
        {
            if ((one.valid == two.valid) && (one.imaginary == two.imaginary))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator >(Complex one, Complex two)
        {
            return one.modul() > two.modul();
        }
        public static bool operator <(Complex one, Complex two)
        {
            return one.modul() < two.modul();
        }

        
            
            



    }
}
