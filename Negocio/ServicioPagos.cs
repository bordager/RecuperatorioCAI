using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class ServicioPagos
    {
        public Mapperpagos map;
    
        public ServicioPagos()
        {
            map = new Mapperpagos();
        }

        public List<Pagos> traer()
        {
            List<Pagos> lista = map.traertodo();
            return lista;
        }

        public ResultadoTransaccion Alta(int id, int idservicio, string fechavencimiento, string fechadepago, string importeadeudado, string interespunitorio, string usuario)

        {
            Pagos nuevo = new Pagos(id, idservicio, fechadevencimiento, fechadepago, importeadeudado, interespunitorio, usuario);
            ResultadoTransaccion res = Mapperpagos.insertar(nuevo);
            return res;
                
        }


    }
}
