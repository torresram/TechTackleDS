using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{

    //Contenedor de las tablas que se necesitan en el programa actualmente
    public static class DiccionarioTablas
    {
        public static Dictionary<int, string> tablaInsumos = new Dictionary<int, string>()
        {
            {0,"Anilla" },
            {1,"Anzuelo" },
            {2,"Blister" },
            {3,"Carcasa" },
            {4,"Carton" },
            {5,"Piton" }
        };
    }
}
