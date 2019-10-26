using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Safari.Business;
using Safari.Entities;
using Safari.Services.Contracts;
namespace Safari.Services.Http
{
    [RoutePrefix("api/Especie")]
    public class EspecieServiceHttp : ApiController
    {
        [HttpPost][Route("Agregar")]
        public AgregarEspecieResponse Agregar(AgregarEspecieRequest request) {
            try {
                var response = new AgregarEspecieResponse();
                var bc = new EspecieComponent();
                response.Result = bc.Add(request.Especie);
                return response;
            }
            catch (Exception ex) {
                var httpError = new HttpResponseMessage()  {
                    StatusCode = (HttpStatusCode)422, // UNPROCESSABLE ENTITY
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("ListarTodos")]
        public ListarTodosEspecieResponse ListarTodos()
        {
            try
            {
                var response = new ListarTodosEspecieResponse();
                var bc = new EspecieComponent();
                response.Result = bc.ToList();
                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422, // UNPROCESSABLE ENTITY
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);
            }
        }
    }
}

