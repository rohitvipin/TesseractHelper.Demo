using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesseract.Helper.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename1 = @"Images\tex1.png";
            var text = Tesseract.Helper.UtliTesseract.GetCaptchaStringFromImage(filename1);
            Console.WriteLine("File : " + filename1 + "\n");
            Console.WriteLine("Text : \n" + text);

            filename1 = @"Images\text2.jpg";
            text = Tesseract.Helper.UtliTesseract.GetCaptchaStringFromImage(filename1);
            Console.WriteLine("File : " + filename1 + "\n");
            Console.WriteLine("Text : \n" + text);

            for (int i = 1; i <= 8; i++)
            {
                var filename2 = @"Images\number (" + i + ").jpg";
                var number = Tesseract.Helper.UtliTesseract.GetCaptchaNumberFromImage(filename2);
                Console.WriteLine("\n\nFile : " + filename2 + "\n");
                Console.WriteLine("Number : \n" + number);
            }

            Console.ReadKey(true);
        }
    }
}
