using ApiPOOmBA.Models;
using ApiPOOmBA.Models.ws;
using ApiPOOmBA.Models.ws2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiPOOmBA.Controllers
{
    public class PreguntasCDMController : ApiController
    {

        [HttpPost]
        public PreguntaReply getPregrunta([FromBody] PreguntasCDMViewModel model)
        {
            PreguntaReply objReply = new PreguntaReply();
            //objReply.result = 0; //falló

            try
            {
                using (DEPOOmBA01Entities db = new DEPOOmBA01Entities())
                {
                    //var lst = db.Pregunta.Where(d => d.nroPregunta == model.nroPregunta);

                    //var pregunta = db.Pregunta.Select(x => x.descripcion).ToList();

                    db.Configuration.LazyLoadingEnabled = true;
                    var pregunta = db.Pregunta.Where(x => x.nroPregunta == model.nroPregunta).First();

                    objReply.pregunta = pregunta.descripcion;

                    objReply.respuesta = new List<RespuestaItem>();
                    var i = 1;

                    foreach (var item in pregunta.Respuesta)
                    {
                        objReply.respuesta.Add(new RespuestaItem
                        {
                            id = i++, //item.idRespuesta,
                            posibleRespuesta = item.descripcion,
                            esLaCorrecta = item.esCorrecta
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                objReply.pregunta = "error de conexión";
            }

            //TEST
            //objReply.pregunta = "El escritor nortearnericano Edgar Allan Poe escribió cuentos detectivescos, protagonizados por un detective frances. ¿Cuál era su nombre?";
            //objReply.respuesta.Add(new RespuestaItem { id = 1, posibleRespuesta = "Auguste Dupin", esLaCorrecta = true });
            //objReply.respuesta.Add(new RespuestaItem { id = 2, posibleRespuesta = "Arsene Lupin", esLaCorrecta = false });


            return objReply;
        }
    }
}
