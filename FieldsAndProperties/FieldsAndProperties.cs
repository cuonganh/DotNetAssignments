using System;

namespace FieldAndProperties
{

    class MyClass
    {
        //Fields
        public int m_Height;
        public int m_Weight;

        //Properties
        private int m_Length;
        public int m_Length
        {
            set
            {
                Debug.WriteLine("Co lenh gan du lieu tu m_Length");
                return 0;
            }
            get
            {    // Neu disable thi chi doc khong duoc phep ghi
                if (_m_Length != value)
                {
                    m_Length = value;
                    Debug.WriteLine("m_Length da bi thay doi gia tri");
                }
            }
        }

        class Four_Leg_Animals
        {
            static int legCount;
            abstract public void Speak()
            {

            }
        }
        class Dog : Four_Leg_Animals
        {
            override public void Speak()
            {
                Console.WriteLine("Go go");
            }
        }
        class Cat : Four_Leg_Animals
        {
            override public void Speak()
            {
                Console.WriteLine("Meo meo");
            }
        }

        static void Processing()
        {
            //Khai bao mot so tai nguyen
            List<int> x = new List<int>();
            try{
                int a, b;
                Console.Write("a = "); a = int.Parse(Console.ReadLine());
                Console.Write("b = "); b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = 2", a, b, a / b);
                Console.ReadKey();
            }catch (DivideByZeroException e){
                Console.WriteLine("Loi chia cho 0");
            }catch (FormatException){
                Console.WriteLine("Loi nhap du lieu khong phai so nguyen");
            }catch (Exception e){
                Console.WriteLine(e.Message);
#if DEBUG                
                throw e;    //Day tiep loi nay ra ngoai
#endif
            }finally{
                // Khoi lenh luon chay ke ca co exception
                x.Clear();  // thu hoi bo nho, giai phong tai nguyen
            }
        }
    }
}



class Program
{
    static void Main(String[] args)
    {
        MyClass a = new MyClass();
        a.m_Length = 10;
        Console.WriteLine("{0} ", a.m_Length);
        Console.WriteLine("Hello world");

        Dog dog = new Dog();
        Cat cat = new Cat();
        dog.Speak();
        cat.Speak();
        Console.WriteLine("{0}", Four_Leg_Animals.legCount());

        try{
            Processing();   // Ham main se nhan duoc moi loi (exception) phat sinh trong Processing
        }
        catch (Exception e){
            throw e;
        }

        try{
            string s;   // Mutable - nội dung không thay đổi
            s = "Hola co";
            if (String.IsNullOrEmpty(s) == false){
                int x = s.Length;
                s = s + "cacola";   // tạo ra "vùng nhớ" mới và trở biến s sang đó
                x = s.Length;
                int i = s.IndexOf("ca");
                int j = s.LastIndexOf("ol");
            }

        }catch{

        }

        try{

            // String s = String.Empty;
            // for (int i = 0; i < 100000; i++){
            //     s = s + i.ToString() + "/n";
            // }
            // Console.WriteLine(s);

            // Sử dụng ít bộ nhớ hơn, nhanh hơn
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++){
                sb.Append(i.ToString());
                sb.Append("\n");
            }
            sb = sb.ToString();

        }catch{

        }

    }

}