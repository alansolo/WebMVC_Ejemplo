using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.LoginDAT
{
    public class EmpleadoDAT
    {
        public List<Empleado> GetEmpleado()
        {
            List<Empleado> listaEmpleado = new List<Datos.Empleado>();

            using (var bd = new VESCEntities())
            {
                listaEmpleado = bd.Empleado.ToList();
            }

            return listaEmpleado;

        }

        public List<Empleado> GetEmpleado(string numEmpleado)
        {
            List<Empleado> listaEmpleado = new List<Datos.Empleado>();

            using (var bd = new VESCEntities())
            {
                listaEmpleado = bd.Empleado.Where(x => x.numEmpleado == numEmpleado).ToList();
            }

            return listaEmpleado;

        }
    }
}
