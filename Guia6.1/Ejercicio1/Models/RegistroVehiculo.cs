using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Models
{
    internal class RegistroVehiculo : IComparable<RegistroVehiculo>
    {
        public string Patente { get; private set; }
        public string Serie { get; private set; }

        public Persona Propietario { get; private set; }

        public RegistroVehiculo(string nPatente, Persona propietario)
        {
           
            if (!ValidarPatente(nPatente))
            {
                throw new FormatoPatenteNoValidaException("La patente debe tener 3 letras y 3 numeros ");
            }

            this.Patente = nPatente.ToUpper();
            
            this.Propietario = propietario;

        }
        /*
        public RegistroVehiculo(string nPatente, Persona propietario, int serie)
        {
            if(!ValidarPatente(nPatente))
            {
                throw new FormatoPatenteNoValidaException("La patente debe tener 3 letras y 3 numeros ");
            }

            this.Patente = nPatente.ToUpper();
            this.Serie = serie.ToString();
            this.Propietario = propietario;

        }

        */
        public string VerDetalle()
        {
            return $"Patente {Patente} - Serie {Serie} - {Propietario.Nombre}(dni: {Propietario.DNI})";
        }

        bool ValidarPatente(string patente)
        {
            string patron = @"^[A-Za-z]{3}[0-9]{3}$";
            return Regex.IsMatch(patente, patron);
            
        }

        public override string ToString()
        {
            return $"{Patente} - Propietario: {Propietario.ToString()}";
        }

        public int CompareTo(RegistroVehiculo other)
        {
            if (other != null)
            {
                return this.Patente.CompareTo(other.Patente);
            }
            return -1;
        }
    }
}
