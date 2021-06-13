using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace ConverterJsonToTxt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string _pathToRead = $"C:\\Users\\opanf\\OneDrive\\Рабочий стол\\Users.json";
            string _pathToWrite = $"C:\\Users\\opanf\\OneDrive\\Рабочий стол\\UserConverted.txt";
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_pathToRead))
                {
                    Console.WriteLine(jsonFromFile = reader.ReadToEnd());
                    File.WriteAllText(_pathToWrite, jsonFromFile);
                }  
            }
            
            
            
        }

    }
}
