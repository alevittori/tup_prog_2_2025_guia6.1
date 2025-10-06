using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class DepartamentoVehicular
    {
       // ArrayList registros = new ArrayList();
        List<RegistroVehiculo>  registros = new List<RegistroVehiculo>();
        
        

        public int CantidadRegistros { get; private set; }

        int nuevaSerie = 0;
        string nuevaPatente = "";


        public RegistroVehiculo RegistrarVehiculo(Persona propietario , string patente)
        {
            RegistroVehiculo nuevoRegistro = new RegistroVehiculo(patente , propietario);
            if(nuevoRegistro != null) { registros.Add(nuevoRegistro); }
            return nuevoRegistro;

        }

        public List<RegistroVehiculo> ObtenerRegistros()
        {
            registros.Sort();
            return registros;
        }

        #region Metodos para la guia 2.2
        /*
        public RegistroVehiculo RegistrarVechiculo(Persona elPropietario)
        {
            CantidadRegistros++;
            
            //tambien puedo generar la serie con el contador de registro, 
            //nuevaSerie = int.Parse(CantidadRegistros.ToString("D9"));


            this.nuevaSerie = GenerarSerie();

            this.nuevaPatente = GenerarPatente();

            RegistroVehiculo unRegistro = new RegistroVehiculo(this.nuevaPatente, elPropietario, this.nuevaSerie);

            Registros.Add(unRegistro);

            return unRegistro;
        }

        string GenerarPatente()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string patente = "";
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                patente += $"{letras[rnd.Next(letras.Length)]}";
            }

            //preguntar a que se refiere de forma secuencial, sino deberiamos cambiar esta formula
            for(int i = 0;i < 3; i++)
            {
                patente += $"{rnd.Next(0, 10)}";
            }
            
            return patente;
        }
        int GenerarSerie()
        {
            Random rnd = new Random();

            string serie = "";
            for (int i = 0; i < 9; i++)
            {
                serie += $"{rnd.Next(0, 9)}";
            }

            return int.Parse(serie);
        }

        //ver como devolver el registro del arraylist
        public RegistroVehiculo VerRegistro(int indice)
        {
            
            if (indice >= 0 && indice < Registros.Count)
            {
                if (Registros[indice] is RegistroVehiculo registro) // por si adentro del arrayList no contiene un tipo RegistroVehicular
                {
                    return registro; 

                }
            }
            return  null;
        }
        //
        */
        #endregion
    }
}
