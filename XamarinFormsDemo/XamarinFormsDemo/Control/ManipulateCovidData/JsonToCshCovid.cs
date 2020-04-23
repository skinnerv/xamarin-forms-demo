using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace XamarinFormsDemo.Control.ManipulateCovidData
{
    class JsonToCshCovid
    {
        private Areas _areas;
        public bool convertJsonToCsh { get; private set; }
        public string jsonString { get; private set; }
        public JsonToCshCovid(Areas areas, string responseHtml)
        {
            _areas = areas;
            jsonString = responseHtml;
            ConvertJsonToCsh();
        }
        
        private void ConvertJsonToCsh()
        {
            try
            {
                _areas = JsonSerializer.Deserialize<Areas>(jsonString);
                //Console.WriteLine("dlpDeserjalizacja przeszła pomyślnie");
                //convertJsonToCsh = true;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("dlp Null Exception Error {0}", ex);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("dlp Http Error {0}", ex);
            }
            catch (Exception e)
            {
                Console.WriteLine("dlp Error {0}", e);
            }
            finally
            {
                Console.WriteLine("dlpKoniec deserjalizacji");
            }
        }
    }
}

