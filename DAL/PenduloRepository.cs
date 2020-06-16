using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PenduloRepository
    {
        string ruta = "pendulo.txt";
        public void Guardar(Pendulo pendulo)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{pendulo.Longitud};{pendulo.masa};{pendulo.oscilaciones};{pendulo.grados};{pendulo.tiempo};" +
                $"{pendulo.Email};{pendulo.Frecuencia};{pendulo.Gravedad}");
            escritor.Close();
            file.Close();
        }
    }
}
