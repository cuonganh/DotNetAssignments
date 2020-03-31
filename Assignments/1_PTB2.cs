using System;

namespace PTB2
{
    class program
    {
        static void Main(String[] args)
        {
            float a, b, c, delta;

            Console.WriteLine("========== Phuong trinh bac hai =========");
            Console.WriteLine("Nhap he so: ");
            Console.Write("\ta = "); a = float.Parse(Console.ReadLine());
            Console.Write("\tb = "); b = float.Parse(Console.ReadLine());
            Console.Write("\tc = "); c = float.Parse(Console.ReadLine());

            try
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Phuong trinh vo so nghiem");
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh {0} = 0 " + c);
                            Console.WriteLine("Phuong trinh vo nghiem");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh bac nhat: {0}x + {1} = 0", b, c);
                        Console.WriteLine("Nghiem cua phuong trinh x = " + -c / b);
                    }
                }

                else
                {
                    Console.WriteLine("Phuong trinh bac hai: {0}x^2 + {1}x + {2} = 0", a, b, c);
                    delta = b * b - 4 * a * c;
                    if (delta > 0)
                    {
                        x1 = -(c + c) / (b + pow(delta, 0.5));
                        x2 = -(c + c) / (b - pow(delta, 0.5));
                        Console.WriteLine("Nghiem x1 = {0} va x2 = {1}", x1, x2);
                    }

                    if (delta = 0)
                    {
                        Console.WriteLine("Nghiem kep x = " + -b / (a + a));
                    }

                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

}

/*  Write a program that reads the coefficients a, b and c 
    of a quadratic equation ax 2+bx+c=0 and solves it (prints its real roots).
    */
