using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDatos.Models
{


    public class Usuarios
    {
    
         public int id { get; set; }
        public string nombres { get; set; }
        
        public string apellidos { get; set; }

        
     


        public int celular { get; set; }

        public string direccion { get; set; }


        public string ciudad { get; set; }

        public string correo { get; set; }

        

    
    /*public Usuarios()

        {
            string[] Lineas = File.ReadAllLines(@"C:\Users\Jaiver\Desktop\Lectura\Lectura\Files\Datos.csv");
            foreach (var item in Lineas)
            {

                var valores = item.Split(',');

                //  Console.WriteLine(valores[0]);

            }

            

            this.nombres = "Jaiver";
            this.apellidos = "Peña";
            this.id = 100121;
            this.celular = 31115555;
            this.ciudad = "Bogota";
            this.direccion = "calle";
            this.correo = "jaiver@gmail.com";
                
        }*/




    }



    }

