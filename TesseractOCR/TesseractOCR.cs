
// using Emc.Captiva.Ocr.Sdk;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Custom.InputAccel.Ocr.TesseractOCR
{
    public class TesseractOCR // : Emc.Captiva.Ocr.Sdk.IOcrEngine
    {
        public string Company => "Cognizant";

        public string Version => "0.1";

        public void DoSnippetRecognition(Bitmap bitmap
            //, IOcrSettings settings, IExtractionResultBuilder builder
            )
        {
            try
            {

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
       
        public void PopulateSnippetRecognitionDefinition(
            // IOcrSettingDefinitions definitions
            )
        {
            // definitions.AddStringDefinition("EngineName", "TesseractOCR");
            
        }
    }

    


}
