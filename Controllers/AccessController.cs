using ApiPOOmBA.Models;
using ApiPOOmBA.Models.ws;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiPOOmBA.Controllers
{
    //[EnableCors(origins: "http://localhost:8100", headers: "*", methods: "*")]
    public class AccessController : ApiController
    {

        [HttpPost]
        public Reply Login([FromBody] UsuarioViewModel model)
        {
            Reply objReply = new Reply();
            objReply.result = 0; //falló

            try
            {
                using (DEPOOmBA01Entities db = new DEPOOmBA01Entities())
                {
                    var lst = db.Usuario.Where(d => d.user == model.usuario && d.password == model.password && d.idEstado == 1);

                    if (lst.Count() > 0)
                    {
                        objReply.result = 1;//result ok
                        objReply.message = "ingreso ok";
                        objReply.token = "tokenPOOmBA01";
                        // objReply.StatusCode = HttpStatusCode.OK;
                    }
                    else
                    {
                        objReply.message = "Usuario o password incorrectos";
                    }
                }
            }
            catch (Exception ex)
            {
                objReply.message = "error de conexión";
            }

            return objReply;
        }


        //[HttpPost]
        //public Reply otroMetodoPost([FromBody] LoQueRecibePorBody modeloDeBody)
        //{
        //    Reply objetoReply = new Reply();
        //    objetoReply.result = 0;
        //    try
        //    {
        //        using (CarreraDeMenteEntities db = new CarreraDeMenteEntities())
        //        {
        //           var listaDeLoQueDevuelve = db.Usuario.Where(d => d.user == modeloDeBody.fede && d.password == modeloDeBody.moni && d.idEstado == modeloDeBody.lucas);

        //            if (listaDeLoQueDevuelve.Count() > 0)
        //            {
        //                objetoReply.message = "vamo' que entramo";
        //                objetoReply.result = 55;
        //                objetoReply.otroGato = "OTRO GATO!!!!!!";

        //            }
        //            else
        //            {
        //                  objetoReply.message = "ERROR NO HAY NADA NO COINCIDE USUARIO O CONTRASEÑA";
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        objetoReply.message = "REVENTO TODO";
        //    }

        //    return objetoReply;
        //}


        //        [HttpPost]
        //        public Reply Pregunta([FromBody] PreguntaViewModel model)
        //        {
        //            Reply objReply = new Reply();
        //            objReply.result = 0; //falló

        //            try
        //            {
        //                using (CarreraDeMenteEntities db = new CarreraDeMenteEntities())
        //                {
        //                    var lst = db.Usuario.Where(d => from u in db.Usuario
        //                                                    join ps in db.PreguntaSecreta on u.idPregunta equals ps.id
        //                                                    where d == model.usuario
        //                                                    select u);


        //                    db.Usuario.Join(db.PreguntaSecreta,
        //     s => s.Id,
        //     sa => sa.ServiceId,
        //     (s, sa) => new { service = s, asgnmt = sa })
        //.Where(ssa => ssa.asgnmt.LocationId == 1)
        //.Select(ssa => ssa.service);

        //                    //from u in db.Usuario
        //                    //join ps in db.PreguntaSecreta on u.idPregunta equals ps.id
        //                    //where sa.LocationId == 1


        //                    if (lst.Count() > 0)
        //                    {
        //                        objReply.result = 1;//result ok
        //                        objReply.message = "ingreso ok";
        //                        // objReply.StatusCode = HttpStatusCode.OK;
        //                    }
        //                    else
        //                    {
        //                        objReply.message = "Usuario o password incorrectos";
        //                    }

        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                objReply.message = "error de conexión";

        //            }

        //            return objReply;
        //        }
    }
}
