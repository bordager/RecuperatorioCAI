using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Mapperpagos
    {
        public List<Pagos> MapList(string deserializar)
        {
            List<Pagos> listadesearilizada = JsonConvert.DeserializeObject<List<Pagos>>(deserializar);
            return listadesearilizada
        }
        public List<Pagos> traertodo()
        {
            string json = WebHelper.Get("/api/v1/PagoMorosos/" + ConfigurationManager.AppSettings["Registro"];
            List<Pagos> result = MapList(json);
            return result;
        }




        public NameValueCollection reversemap(Pagos a)
        {
            NameValueCollection b = new NameValueCollection();
            b.Add("id", a.id.ToString());
            b.Add("idServicio", a.idservicio.ToString());
            b.Add("fechaVencimiento", a.fechadevencimiento.ToString());
            b.Add("fechaPago", a.fechadepago.ToString());
            b.Add("importeAdeudado", a.importeadeudado.ToString());
            b.Add("interesPunitorio", a.interespunitorio.ToString());
            b.Add("usuario", a.usuario.ToString());

            return b;
        }

        public ResultadoTransaccion Resultado(string resultado)
        {
            ResultadoTransaccion mapresult = JsonConvert.DeserializeObject<ResultadoTransaccion>(resultado);
            return mapresult;
        }

        public ResultadoTransaccion insertar(Pagos nuevopago)

        {
            NameValueCollection a = reversemap(nuevopago);
            string respuesta = WebHelper.Post("/api/v1/PagoMorosos/", a);
            ResultadoTransaccion resultadoTransaccion = Resultado(respuesta);
            return resultadoTransaccion;
        }

    }

}
