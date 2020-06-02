using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario
{
    class Receta
    {
        public String nombre;
        public List<Ingrediente> ingredientes;
        public List<Paso> pasos;
        public String coccion;
        public Int16 tiempo;
        public Int16 calorias;
        public Boolean dulce;
        public Boolean salado;

    }
}
