using System;
using System.IO;

namespace FileExam{
    class Program{
        static void Main(String[] args){
            try{
                // Stream reader = new StreamReader("tmp.txt");
                // String s = reader.ReadToEnd();
                // Console.WriteLine(s);

                // reader.Close();
                // reader.Dispose();
                // //Bat buoc phai goi thi Garbage Collector don dep

                using(StreamReader reader = new StreamReader("text.txt")){
                    //Tu dong Close va Dispose doi tuong khi het pham vi
                    String s = reader.ReadToEnd();
                    Console.WriteLine(s);
                }
                
            }catch(FileNotFoundException ex){
                Console.WriteLine("Duong dan file bi sai");
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            
        }
    }
}