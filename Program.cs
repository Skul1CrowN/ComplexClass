class Program
{
    static void Main(string[] args)
    {
        Complex test1 = new Complex(3,4);
        Complex test2 = new Complex(-5,-5);
        Complex.PrintComplex( test1 - new Complex(1,1) );
    }
}