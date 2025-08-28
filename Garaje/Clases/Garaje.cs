using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.Clases
{
    public class Garaje
    {
        // Atributos
        public int numeroGaraje { get; set; }
        public string descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }

        // Constructor para inicializar todas las variables
        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }

        // Método para retornar el número de espacios disponibles
        public int getEspaciosDisponibles()
        {
            return capacidadEspacios - espaciosOcupados;
        }

        // Método para actualizar los espacios ocupados
        public void setEspaciosOcupados(int espaciosSolicitados)
        {
            this.espaciosOcupados = this.espaciosOcupados + espaciosSolicitados;
        }
    }
}
