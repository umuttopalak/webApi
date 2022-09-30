using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace TodoApi.Controllers
{
    class Program
    {
        //kök dizini
        static readonly string rootFolder = @"D:\Umut\TodoApi\TodoApi";

        //işlem yapılacak txt dosyası
        static readonly string textFile = @"D:\Umut\TodoApi\TodoApi\DataTest\data.txt";

        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                // Tüm bilgileri tek bir string halinde okuma ve yazdırma
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
            }
        }
    }
}
