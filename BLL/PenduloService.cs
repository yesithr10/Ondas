using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Infraestructura;

namespace BLL
{
    public class PenduloService
    {
        Email email = new Email();
        string mensajeEmail = String.Empty;
        PenduloRepository penduloRepository;
        public PenduloService()
        {
            penduloRepository = new PenduloRepository();
        }
        public double calcularFrecuencia(Pendulo pendulo)
        {
            pendulo.Frecuencia = pendulo.tiempo / pendulo.oscilaciones;
            return pendulo.Frecuencia;
        }
        public double calcularGravedad(Pendulo pendulo)
        {
            pendulo.Gravedad = Convert.ToDouble(((39.4786) * (pendulo.Longitud)) / (pendulo.Frecuencia * pendulo.Frecuencia));
            return pendulo.Gravedad;
        }
        public string Guardar(Pendulo pendulo)
        {
            try
            {
                penduloRepository.Guardar(pendulo);
                mensajeEmail = email.EnviarEmail(pendulo);
                return ($"los datos de su practica se han guardado satisfactoriamente " + mensajeEmail);
            }
            catch (Exception e)
            {
                return ($"Eror de datos: {e.Message}");
            }

        }
    }
}
