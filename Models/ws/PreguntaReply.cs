using ApiPOOmBA.Models.ws2;
using System.Collections.Generic;

namespace ApiPOOmBA.Models.ws
{
    public class PreguntaReply
    {
        public string pregunta { get; set; }
        public List<RespuestaItem> respuesta { get; set; }
    }
}