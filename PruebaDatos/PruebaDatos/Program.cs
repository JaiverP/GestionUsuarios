using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PruebaDatos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PruebaDatos
{

    public class Program
    {

     
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            File.ReadAllLines("");

        }
        public void CargarRegistros()
        {

           
            string[] Lineas = File.ReadAllLines(@"C:\Users\Jaiver\Desktop\Lectura\Lectura\Files\Datos.csv");
            foreach (var item in Lineas)
            {

                var valores = item.Split(',');

                //  Console.WriteLine(valores[0]);

            }


        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
