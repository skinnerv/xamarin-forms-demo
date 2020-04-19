using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace XamarinFormsDemo.Control.ManipulateCovidData
{
    class JsonToCshCovid
    {
        public string jsonString;
        void ConvertJsonToCsh()
        {
            try
            {
                var areas = JsonSerializer.Deserialize<Areas>(jsonString);
                Console.WriteLine("dlpDeserjalizacja przeszła pomyślnie");
            }
            catch (Exception e)
            {

                Console.WriteLine("dlpError {0}", e);
            }
            finally
            {
                Console.WriteLine("dlpKoniec deserjalizacji");
            }
        }
    }
}

