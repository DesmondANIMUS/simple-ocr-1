using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;

namespace CV_demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading image....");
            var image = new Image<Bgr, byte>("data.png");            
            var tesOCRprovider = new Tesseract("./tessdata", "eng", OcrEngineMode.TesseractCubeCombined);

            Console.WriteLine("Analysing data....");
            tesOCRprovider.Recognize(image);
            Tesseract.Character[] characters = tesOCRprovider.GetCharacters();

            var text = tesOCRprovider.GetText();
            Console.WriteLine("\n\n");

            Console.WriteLine(text);
            Console.WriteLine("\n\nDone");
            Console.ReadLine();
        }
    }
}
