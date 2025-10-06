using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Persona
    {
        string dni;
        public string DNI 
        {
            get { return dni; }

            set
            {
                // Validar que el DNI tenga solo dígitos
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d+$"))
                {
                    throw new RangoDniIncorrectoException("El DNI debe contener solo números.");
                }

                // Validar que el valor numérico sea mayor a un millón
                if (!long.TryParse(value, out long dniNumerico) || dniNumerico <= 1000000)
                {
                    throw new RangoDniIncorrectoException("El DNI debe ser mayor a un millón.");
                }

                dni = value;
            } 
        
        }
        public string Nombre { get; private set; }

        public Persona(string dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        public string VerDatos()
        {
            return $"{Nombre} (dni: { DNI})";
        }

        public override string ToString() 
        {
            return VerDatos();
        }
    }
}
