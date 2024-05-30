using System;
// using Emc.Captiva.Ocr.Sdk;
using System.Drawing;
using Tesseract;

namespace Custom.InputAccel.Ocr.TesseractOCR
{
    class TesseractOCREngine
    {
        public struct Vertices
        {
            public int X;
            public int Y;
        }

        public class Character
        {
            public string Text;
            public float Confidence;
            public readonly Vertices[] Bound = new Vertices[4];
        }

        public void ProcessImage(Bitmap bitmap
            // , IExtractionResultBuilder builder1
            )
        {
            string dataPath = null;
            string language = null;
            using (var engine = new TesseractEngine(dataPath, language, EngineMode.Default))
            {
                // Load the image you want to perform OCR on
                using (var img = PixConverter.ToPix(bitmap)) // Pix.LoadFromFile("path/to/your/image.png")
                {
                    // Run the OCR process
                    using (var page = engine.Process(img))
                    {
                        // Extract the recognized text
                        string text = page.GetText();

                        // Output or use the extracted text
                        Console.WriteLine(text);
                        // Rectangle bounds = new Rectangle(s.Bound[0].X, s.Bound[0].Y, s.Bound[1].X - s.Bound[0].X, s.Bound[3].Y - s.Bound[0].Y);
                        // builder.AddNewCharacter(s.Text, (int)(Math.Round(s.Confidence * 100)), bounds);

                    }
                }
            }
        }
    }
}
