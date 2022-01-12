public class Complex
{
    private double re;
    private double ima;
    public Complex(){re = 0; ima = 0;}
    public Complex(double r, double i){re = r; ima = i;}
    public static Complex operator +(Complex c)
        => c;
    public static Complex operator -(Complex c)
        => new Complex(-c.re, -c.ima);
    public static Complex operator +(Complex c1, Complex c2)
        => new Complex(c1.re + c2.re, c1.ima + c2.ima);
    public static Complex operator -(Complex c1, Complex c2)
        => c1 + (-c2);
    public static Complex operator *(Complex c1, Complex c2)
        => new Complex(c1.re*c2.re - c1.ima*c2.ima, c1.ima*c2.re + c1.re*c2.ima);
    public static Complex operator *(Complex c, double d)
        => new Complex(c.re*d,c.ima*d);
    public static Complex operator /(Complex c1, Complex c2)
    {
        if(c2.re*c2.re + c2.ima*c2.ima == 0)
            throw new DivideByZeroException();
        return new Complex((c1.re*c2.re + c1.ima*c2.ima)/(c2.re*c2.re + c2.ima*c2.ima),(c1.ima*c1.re - c1.re*c2.ima)/(c2.re*c2.re + c2.ima*c2.ima));
    }
    public static Complex operator /(Complex c, double d)
    {
        if(d == 0)
            throw new DivideByZeroException();
        return new Complex(c.re/d,c.ima/d);
    }
    public static double GetReal(Complex c){ return c.re; }
    public static double GetImagine(Complex c){ return c.ima; }
    public static Complex Conjugate(Complex c){ return new Complex(c.re,-c.ima); }
    public static double Abs(Complex c){ return Math.Sqrt(c.re*c.re + c.ima*c.ima); }
    
    public static void PrintComplex(Complex c)
    {
        Console.Write(c.re != 0 ? c.re : (c.re == 0 && c.ima == 0 ? "0" : "") );
        Console.Write(c.ima > 0 && c.re != 0 ? "+" : "");
        Console.WriteLine(c.ima != 0 ? c.ima+"i": "");
    }
}