using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCloudVisionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static object DetectText(string filePath)
        {
            var client = ImageAnnotatorClient.Create();
            var image = MediaTypeNames.Image.FromFile(filePath);
            var response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
            return 0;
        }
    }
}
